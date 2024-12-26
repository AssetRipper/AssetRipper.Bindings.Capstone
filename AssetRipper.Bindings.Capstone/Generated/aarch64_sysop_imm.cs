using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

[StructLayout(LayoutKind.Explicit)]
public partial struct aarch64_sysop_imm
{
    [FieldOffset(0)]
    public aarch64_dbnxs dbnxs;

    [FieldOffset(0)]
    public aarch64_exactfpimm exactfpimm;

    [FieldOffset(0)]
    public int raw_val;
}
