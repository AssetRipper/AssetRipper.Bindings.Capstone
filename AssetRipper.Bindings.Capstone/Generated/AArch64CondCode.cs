namespace AssetRipper.Bindings.Capstone;

public enum AArch64CondCode
{
    AArch64CC_EQ = 0x0,
    AArch64CC_NE = 0x1,
    AArch64CC_HS = 0x2,
    AArch64CC_LO = 0x3,
    AArch64CC_MI = 0x4,
    AArch64CC_PL = 0x5,
    AArch64CC_VS = 0x6,
    AArch64CC_VC = 0x7,
    AArch64CC_HI = 0x8,
    AArch64CC_LS = 0x9,
    AArch64CC_GE = 0xa,
    AArch64CC_LT = 0xb,
    AArch64CC_GT = 0xc,
    AArch64CC_LE = 0xd,
    AArch64CC_AL = 0xe,
    AArch64CC_NV = 0xf,
    AArch64CC_Invalid,
    AArch64CC_ANY_ACTIVE = AArch64CC_NE,
    AArch64CC_FIRST_ACTIVE = AArch64CC_MI,
    AArch64CC_LAST_ACTIVE = AArch64CC_LO,
    AArch64CC_NONE_ACTIVE = AArch64CC_EQ,
}
