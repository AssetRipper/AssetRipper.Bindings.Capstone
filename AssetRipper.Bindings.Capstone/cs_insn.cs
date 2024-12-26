using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

partial struct cs_insn
{
	[StackTraceHidden]
	[MemberNotNull(nameof(detail))]
	public unsafe readonly void ThrowIfDetailIsNull()
	{
		if (detail is null)
		{
			throw new ArgumentException("Instruction detail is null");
		}
	}

	public readonly string Mnemonic => GetString(mnemonic);

	public readonly string Operand => GetString(op_str);

	private static unsafe string GetString(ReadOnlySpan<sbyte> data)
	{
		int length = data.IndexOf((sbyte)0);
		if (length <= 0)
		{
			return "";
		}
		else
		{
			fixed (sbyte* ptr = data)
			{
				return Marshal.PtrToStringAnsi((IntPtr)ptr, length);
			}
		}
	}
}
