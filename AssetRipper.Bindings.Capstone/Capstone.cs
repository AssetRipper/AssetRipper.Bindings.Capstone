using AssetRipper.Bindings.Capstone.Instructions;
using System;
using System.Collections.Generic;
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

	public static unsafe List<T> Iterate<T>(ReadOnlySpan<byte> data, int start, ulong address, cs_mode mode = default) where T : IInstruction<T>
	{
		nuint handle = default;
		cs_open(T.Architecture, mode, &handle).ThrowOnFailure();
		try
		{
			cs_option(handle, cs_opt_type.CS_OPT_DETAIL, cs_opt_value.CS_OPT_ON).ThrowOnFailure();

			List<T> result = new();
			fixed (byte* dataPtr = data)
			{
				byte* position = dataPtr + start;
				nuint size = default;
				cs_insn insn = default;
				while (cs_disasm_iter(handle, &position, &size, &address, &insn))
				{
					result.Add(T.FromNative(insn));
				}
			}

			return result;
		}
		finally
		{
			cs_close(&handle).ThrowOnFailure();
		}
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
