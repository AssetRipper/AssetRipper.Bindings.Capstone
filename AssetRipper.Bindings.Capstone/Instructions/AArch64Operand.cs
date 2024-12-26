namespace AssetRipper.Bindings.Capstone.Instructions;

public readonly record struct AArch64Operand
{
	public aarch64_op_type Type { get; init; }
	public aarch64_reg Register { get; init; }
	public long Immediate { get; init; }
	public double FloatingPoint { get; init; }

	internal static AArch64Operand FromNative(cs_aarch64_op native)
	{
		return new()
		{
			Type = native.type,
			Register = native.reg,
			Immediate = native.imm,
			FloatingPoint = native.fp,
		};
	}
}
