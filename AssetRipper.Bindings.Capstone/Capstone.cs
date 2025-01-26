using AssetRipper.Bindings.Capstone.Instructions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial class Capstone
{
	public static unsafe T[] Disassemble<T>(ReadOnlySpan<byte> data, ulong address, cs_mode mode = default) where T : IInstruction<T>
	{
		nuint handle = default;
		cs_open(T.Architecture, mode, &handle).ThrowOnFailure();
		try
		{
			cs_option(handle, cs_opt_type.CS_OPT_DETAIL, cs_opt_value.CS_OPT_ON).ThrowOnFailure();

			cs_insn* insn = null;
			nuint instructionCount;
			fixed (byte* dataPtr = data)
			{
				instructionCount = cs_disasm(handle, dataPtr, (nuint)data.Length, address, 0, &insn);
			}

			if (instructionCount == 0)
			{
				return [];
			}

			try
			{
				ReadOnlySpan<cs_insn> instructions = new(insn, (int)instructionCount);
				T[] result = new T[instructionCount];
				for (int i = (int)instructionCount - 1; i >= 0; i--)
				{
					result[i] = T.FromNative(instructions[i]);
				}
				return result;
			}
			finally
			{
				cs_free(insn, instructionCount);
			}
		}
		finally
		{
			cs_close(&handle).ThrowOnFailure();
		}
	}

	public static IEnumerable<T> Iterate<T>(byte[] data, int start, ulong address, cs_mode mode = default) where T : IInstruction<T>
	{
		int offset = start;
		cs_insn insn = default;
		while (true)
		{
			if (_helper(data, ref offset, ref address, ref insn, mode))
			{
				yield return T.FromNative(insn);
			}
			else
			{
				break;
			}
		}

		static unsafe bool _helper(byte[] data, ref int offset, ref ulong address, ref cs_insn insn, cs_mode mode)
		{
			cs_open(T.Architecture, mode, out nuint handle).ThrowOnFailure();
			cs_insn* insn2 = cs_malloc(handle);
			try
			{
				cs_option(handle, cs_opt_type.CS_OPT_DETAIL, cs_opt_value.CS_OPT_ON).ThrowOnFailure();

				if (insn2 == null)
					throw new();

				bool success;
				fixed (byte* dataPtr = data)
				{
					byte* position = dataPtr + offset;
					nuint size = (nuint)(data.Length);
					success = cs_disasm_iter(handle, &position, &size, (ulong*)Unsafe.AsPointer(ref address), insn2);
					insn = *insn2;
					offset = (int)(position - dataPtr);
				}
				return success;
			}
			finally
			{
				cs_free(insn2, 1);
				cs_close(ref handle).ThrowOnFailure();
			}
		}
	}

	public static unsafe cs_err cs_open(cs_arch arch, cs_mode mode, out nuint handle)
	{
		handle = default;
		return cs_open(arch, mode, (nuint*)Unsafe.AsPointer(ref handle));
	}

	public static unsafe cs_err cs_close(ref nuint handle)
	{
		return cs_close((nuint*)Unsafe.AsPointer(ref handle));
	}

	public static cs_err cs_option(nuint handle, cs_opt_type type, cs_opt_value value)
	{
		return cs_option(handle, type, (nuint)value);
	}

	public static unsafe string? GetErrorString(cs_err error)
	{
		sbyte* ptr = cs_strerror(error);
		return Marshal.PtrToStringAnsi((nint)ptr);
	}
}
