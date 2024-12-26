namespace AssetRipper.Bindings.Capstone;

public enum cs_op_type
{
    CS_OP_INVALID = 0,
    CS_OP_REG = 1,
    CS_OP_IMM = 2,
    CS_OP_FP = 3,
    CS_OP_PRED = 4,
    CS_OP_RESERVED_5 = 5,
    CS_OP_RESERVED_6 = 6,
    CS_OP_RESERVED_7 = 7,
    CS_OP_RESERVED_8 = 8,
    CS_OP_RESERVED_9 = 9,
    CS_OP_RESERVED_10 = 10,
    CS_OP_RESERVED_11 = 11,
    CS_OP_RESERVED_12 = 12,
    CS_OP_RESERVED_13 = 13,
    CS_OP_RESERVED_14 = 14,
    CS_OP_RESERVED_15 = 15,
    CS_OP_SPECIAL = 0x10,
    CS_OP_BOUND = 0x40,
    CS_OP_MEM = 0x80,
    CS_OP_MEM_REG = CS_OP_MEM | CS_OP_REG,
    CS_OP_MEM_IMM = CS_OP_MEM | CS_OP_IMM,
}
