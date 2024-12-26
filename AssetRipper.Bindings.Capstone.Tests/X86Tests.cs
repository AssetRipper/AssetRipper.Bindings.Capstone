using AssetRipper.Bindings.Capstone.Instructions;

namespace AssetRipper.Bindings.Capstone.Tests;

public class X86Tests
{
	[Test]
	public void SimpleSequence()
	{
		ReadOnlySpan<byte> data = "\x55\x48\x8b\x05\xb8\x13\x00\x00"u8;
		X86Instruction[] instructions = Capstone.Disassemble<X86Instruction>(data, 0x1000, cs_mode.CS_MODE_64);
		Assert.That(instructions, Is.Not.Empty);
	}
}
