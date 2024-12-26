namespace AssetRipper.Bindings.Capstone;

public enum aarch64_prfm
{
    AARCH64_PRFM_PLDL1KEEP = 0x0,
    AARCH64_PRFM_PLDL1STRM = 0x1,
    AARCH64_PRFM_PLDL2KEEP = 0x2,
    AARCH64_PRFM_PLDL2STRM = 0x3,
    AARCH64_PRFM_PLDL3KEEP = 0x4,
    AARCH64_PRFM_PLDL3STRM = 0x5,
    AARCH64_PRFM_PLDSLCKEEP = 0x6,
    AARCH64_PRFM_PLDSLCSTRM = 0x7,
    AARCH64_PRFM_PLIL1KEEP = 0x8,
    AARCH64_PRFM_PLIL1STRM = 0x9,
    AARCH64_PRFM_PLIL2KEEP = 0xa,
    AARCH64_PRFM_PLIL2STRM = 0xb,
    AARCH64_PRFM_PLIL3KEEP = 0xc,
    AARCH64_PRFM_PLIL3STRM = 0xd,
    AARCH64_PRFM_PLISLCKEEP = 0xe,
    AARCH64_PRFM_PLISLCSTRM = 0xf,
    AARCH64_PRFM_PSTL1KEEP = 0x10,
    AARCH64_PRFM_PSTL1STRM = 0x11,
    AARCH64_PRFM_PSTL2KEEP = 0x12,
    AARCH64_PRFM_PSTL2STRM = 0x13,
    AARCH64_PRFM_PSTL3KEEP = 0x14,
    AARCH64_PRFM_PSTL3STRM = 0x15,
    AARCH64_PRFM_PSTSLCKEEP = 0x16,
    AARCH64_PRFM_PSTSLCSTRM = 0x17,
    AARCH64_PRFM_ENDING,
}