namespace AssetRipper.Bindings.Capstone.Instructions;

public readonly record struct AArch64Instruction : IInstruction<AArch64Instruction>
{
	public ulong Address { get; init; }
	public aarch64_insn ID { get; init; }
	public AArch64CondCode ConditionCode { get; init; }

	public AArch64Operand Op0 { get; init; }
	public AArch64Operand Op1 { get; init; }
	public AArch64Operand Op2 { get; init; }
	public AArch64Operand Op3 { get; init; }

	static unsafe AArch64Instruction IInstruction<AArch64Instruction>.FromNative(cs_insn native)
	{
		native.ThrowIfDetailIsNull();

		return new()
		{
			Address = native.address,
			ID = (aarch64_insn)native.id,
			ConditionCode = native.detail->aarch64.cc,
			Op0 = AArch64Operand.FromNative(GetOp(native, 0)),
			Op1 = AArch64Operand.FromNative(GetOp(native, 1)),
			Op2 = AArch64Operand.FromNative(GetOp(native, 2)),
			Op3 = AArch64Operand.FromNative(GetOp(native, 3)),
		};

		static cs_aarch64_op GetOp(cs_insn native, int index)
		{
			if (index >= native.detail->aarch64.op_count)
			{
				return default;
			}
			return native.detail->aarch64.operands[index];
		}
	}

	static cs_arch IInstruction<AArch64Instruction>.Architecture => cs_arch.CS_ARCH_AARCH64;
}
