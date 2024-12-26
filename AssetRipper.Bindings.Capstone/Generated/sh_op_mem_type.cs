namespace AssetRipper.Bindings.Capstone;

public enum sh_op_mem_type
{
    SH_OP_MEM_INVALID = 0,
    SH_OP_MEM_REG_IND,
    SH_OP_MEM_REG_POST,
    SH_OP_MEM_REG_PRE,
    SH_OP_MEM_REG_DISP,
    SH_OP_MEM_REG_R0,
    SH_OP_MEM_GBR_DISP,
    SH_OP_MEM_GBR_R0,
    SH_OP_MEM_PCR,
    SH_OP_MEM_TBR_DISP,
}
