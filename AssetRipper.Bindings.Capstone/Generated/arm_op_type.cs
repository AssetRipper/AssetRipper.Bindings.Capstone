namespace AssetRipper.Bindings.Capstone;

public enum arm_op_type
{
    ARM_OP_INVALID = cs_op_type.CS_OP_INVALID,
    ARM_OP_REG = cs_op_type.CS_OP_REG,
    ARM_OP_IMM = cs_op_type.CS_OP_IMM,
    ARM_OP_FP = cs_op_type.CS_OP_FP,
    ARM_OP_PRED = cs_op_type.CS_OP_PRED,
    ARM_OP_CIMM = cs_op_type.CS_OP_SPECIAL + 0,
    ARM_OP_PIMM = cs_op_type.CS_OP_SPECIAL + 1,
    ARM_OP_SETEND = cs_op_type.CS_OP_SPECIAL + 2,
    ARM_OP_SYSREG = cs_op_type.CS_OP_SPECIAL + 3,
    ARM_OP_BANKEDREG = cs_op_type.CS_OP_SPECIAL + 4,
    ARM_OP_SPSR = cs_op_type.CS_OP_SPECIAL + 5,
    ARM_OP_CPSR = cs_op_type.CS_OP_SPECIAL + 6,
    ARM_OP_SYSM = cs_op_type.CS_OP_SPECIAL + 7,
    ARM_OP_VPRED_R = cs_op_type.CS_OP_SPECIAL + 8,
    ARM_OP_VPRED_N = cs_op_type.CS_OP_SPECIAL + 9,
    ARM_OP_MEM = cs_op_type.CS_OP_MEM,
}
