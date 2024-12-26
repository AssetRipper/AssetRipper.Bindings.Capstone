using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct aarch64_op_sme
{
    public aarch64_sme_op_type type;

    public aarch64_reg tile;

    public aarch64_reg slice_reg;

    [NativeTypeName("__AnonymousRecord_aarch64_L2794_C2")]
    public _slice_offset_e__Union slice_offset;

    public bool has_range_offset;

    public bool is_vertical;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _slice_offset_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint16_t")]
        public ushort imm;

        [FieldOffset(0)]
        public aarch64_imm_range imm_range;
    }
}
