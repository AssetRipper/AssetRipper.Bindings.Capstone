using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

[StructLayout(LayoutKind.Explicit)]
public partial struct aarch64_sysop_reg
{
    [FieldOffset(0)]
    public aarch64_sysreg sysreg;

    [FieldOffset(0)]
    public aarch64_tlbi tlbi;

    [FieldOffset(0)]
    public aarch64_ic ic;

    [FieldOffset(0)]
    public int raw_val;
}
