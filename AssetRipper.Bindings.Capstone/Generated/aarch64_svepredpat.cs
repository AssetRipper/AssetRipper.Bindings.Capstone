namespace AssetRipper.Bindings.Capstone;

public enum aarch64_svepredpat
{
    AARCH64_SVEPREDPAT_ALL = 0x1f,
    AARCH64_SVEPREDPAT_MUL3 = 0x1e,
    AARCH64_SVEPREDPAT_MUL4 = 0x1d,
    AARCH64_SVEPREDPAT_POW2 = 0x0,
    AARCH64_SVEPREDPAT_VL1 = 0x1,
    AARCH64_SVEPREDPAT_VL128 = 0xc,
    AARCH64_SVEPREDPAT_VL16 = 0x9,
    AARCH64_SVEPREDPAT_VL2 = 0x2,
    AARCH64_SVEPREDPAT_VL256 = 0xd,
    AARCH64_SVEPREDPAT_VL3 = 0x3,
    AARCH64_SVEPREDPAT_VL32 = 0xa,
    AARCH64_SVEPREDPAT_VL4 = 0x4,
    AARCH64_SVEPREDPAT_VL5 = 0x5,
    AARCH64_SVEPREDPAT_VL6 = 0x6,
    AARCH64_SVEPREDPAT_VL64 = 0xb,
    AARCH64_SVEPREDPAT_VL7 = 0x7,
    AARCH64_SVEPREDPAT_VL8 = 0x8,
    AARCH64_SVEPREDPAT_ENDING,
}