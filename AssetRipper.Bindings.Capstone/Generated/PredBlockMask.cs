namespace AssetRipper.Bindings.Capstone;

public enum PredBlockMask
{
    ARM_PredBlockMaskInvalid = 0,
    ARM_T = 0x8,
    ARM_TT = 0x4,
    ARM_TE = 0xc,
    ARM_TTT = 0x2,
    ARM_TTE = 0x6,
    ARM_TEE = 0xe,
    ARM_TET = 0xa,
    ARM_TTTT = 0x1,
    ARM_TTTE = 0x3,
    ARM_TTEE = 0x7,
    ARM_TTET = 0x5,
    ARM_TEEE = 0xf,
    ARM_TEET = 0xd,
    ARM_TETT = 0x9,
    ARM_TETE = 0xb,
}
