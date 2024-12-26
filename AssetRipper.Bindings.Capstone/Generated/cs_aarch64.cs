using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_aarch64
{
    [NativeTypeName("AArch64CC_CondCode")]
    public AArch64CondCode cc;

    public bool update_flags;

    public bool post_index;

    public bool is_doing_sme;

    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_aarch64_op[16]")]
    public _operands_e__FixedBuffer operands;

    [InlineArray(16)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_aarch64_op e0;
    }
}
