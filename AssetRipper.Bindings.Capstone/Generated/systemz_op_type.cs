namespace AssetRipper.Bindings.Capstone;

public enum systemz_op_type
{
    SYSTEMZ_OP_INVALID = cs_op_type.CS_OP_INVALID,
    SYSTEMZ_OP_REG = cs_op_type.CS_OP_REG,
    SYSTEMZ_OP_IMM = cs_op_type.CS_OP_IMM,
    SYSTEMZ_OP_MEM = cs_op_type.CS_OP_MEM,
}
