using AssetRipper.Bindings.Capstone.Instructions;

namespace AssetRipper.Bindings.Capstone.Tests;

public class X86Tests
{
	// mov eax, 5
	// add eax, 3
	// sub eax, 1
	// mov ebx, eax
	// int 0x80
	private static ReadOnlySpan<byte> Assembly => "\xB8\x05\x00\x00\x00\x83\xC0\x03\x83\xE8\x01\x89\xC3\xCD\x80"u8;

	[Test]
	public void DisassemblyIsNotEmpty()
	{
		X86Instruction[] instructions = Capstone.Disassemble<X86Instruction>(Assembly, 0x1000, cs_mode.CS_MODE_64);
		Assert.That(instructions, Is.Not.Empty);
	}

	[Test]
	public void DisassembleIsEquivalentToIterate()
	{
		X86Instruction[] instructions1 = Capstone.Disassemble<X86Instruction>(Assembly, 0x1000, cs_mode.CS_MODE_64);
		X86Instruction[] instructions2 = Capstone.Iterate<X86Instruction>(Assembly.ToArray(), 0, 0x1000, cs_mode.CS_MODE_64).ToArray();
		Assert.That(instructions1, Is.EquivalentTo(instructions2));
	}
}
