namespace AssetRipper.Bindings.Capstone.Instructions;

public interface IInstruction<TSelf> where TSelf : IInstruction<TSelf>
{
	static abstract cs_arch Architecture { get; }
	static abstract TSelf FromNative(cs_insn native);
}
