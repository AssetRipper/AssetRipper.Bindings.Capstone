namespace AssetRipper.Bindings.Capstone;

public enum ppc_op_type
{
    PPC_OP_INVALID = cs_op_type.CS_OP_INVALID,
    PPC_OP_REG = cs_op_type.CS_OP_REG,
    PPC_OP_IMM = cs_op_type.CS_OP_IMM,
    PPC_OP_MEM = cs_op_type.CS_OP_MEM,
}
