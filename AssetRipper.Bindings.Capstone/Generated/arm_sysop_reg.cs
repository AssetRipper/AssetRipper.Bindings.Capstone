using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

[StructLayout(LayoutKind.Explicit)]
public partial struct arm_sysop_reg
{
    [FieldOffset(0)]
    public arm_sysreg mclasssysreg;

    [FieldOffset(0)]
    public arm_bankedreg bankedreg;

    [FieldOffset(0)]
    public int raw_val;
}
