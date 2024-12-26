using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

[StructLayout(LayoutKind.Explicit)]
public partial struct aarch64_sysop_alias
{
    [FieldOffset(0)]
    public aarch64_svcr svcr;

    [FieldOffset(0)]
    public aarch64_at at;

    [FieldOffset(0)]
    public aarch64_db db;

    [FieldOffset(0)]
    public aarch64_dc dc;

    [FieldOffset(0)]
    public aarch64_isb isb;

    [FieldOffset(0)]
    public aarch64_tsb tsb;

    [FieldOffset(0)]
    public aarch64_prfm prfm;

    [FieldOffset(0)]
    public aarch64_sveprfm sveprfm;

    [FieldOffset(0)]
    public aarch64_rprfm rprfm;

    [FieldOffset(0)]
    public aarch64_pstateimm0_15 pstateimm0_15;

    [FieldOffset(0)]
    public aarch64_pstateimm0_1 pstateimm0_1;

    [FieldOffset(0)]
    public aarch64_psb psb;

    [FieldOffset(0)]
    public aarch64_bti bti;

    [FieldOffset(0)]
    public aarch64_svepredpat svepredpat;

    [FieldOffset(0)]
    public aarch64_sveveclenspecifier sveveclenspecifier;

    [FieldOffset(0)]
    public int raw_val;
}
