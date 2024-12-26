namespace AssetRipper.Bindings.Capstone.Instructions;

// Mostly for testing purposes. Iced is probably better for production use.
public readonly record struct X86Instruction : IInstruction<X86Instruction>
{
	public ulong Address { get; init; }
	public x86_insn ID { get; init; }

	static unsafe X86Instruction IInstruction<X86Instruction>.FromNative(cs_insn native)
	{
		native.ThrowIfDetailIsNull();

		return new()
		{
			Address = native.address,
			ID = (x86_insn)native.id,
		};
	}

	static cs_arch IInstruction<X86Instruction>.Architecture => cs_arch.CS_ARCH_X86;
}
