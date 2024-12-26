namespace AssetRipper.Bindings.Capstone;

public enum cs_xtensa_op_type
{
    XTENSA_OP_INVALID = cs_op_type.CS_OP_INVALID,
    XTENSA_OP_REG = cs_op_type.CS_OP_REG,
    XTENSA_OP_IMM = cs_op_type.CS_OP_IMM,
    XTENSA_OP_MEM = cs_op_type.CS_OP_MEM,
    XTENSA_OP_MEM_REG = cs_op_type.CS_OP_MEM_REG,
    XTENSA_OP_MEM_IMM = cs_op_type.CS_OP_MEM_IMM,
    XTENSA_OP_L32R,
}
