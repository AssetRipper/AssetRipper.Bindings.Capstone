using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_arm
{
    public bool usermode;

    public int vector_size;

    public arm_vectordata_type vector_data;

    public arm_cpsmode_type cps_mode;

    public arm_cpsflag_type cps_flag;

    [NativeTypeName("ARMCC_CondCodes")]
    public CondCodes cc;

    [NativeTypeName("ARMVCC_VPTCodes")]
    public VPTCodes vcc;

    public bool update_flags;

    public bool post_index;

    [NativeTypeName("arm_mem_bo_opt")]
    public MemBOpt mem_barrier;

    [NativeTypeName("uint8_t")]
    public byte pred_mask;

    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_arm_op[36]")]
    public _operands_e__FixedBuffer operands;

    [InlineArray(36)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_arm_op e0;
    }
}
