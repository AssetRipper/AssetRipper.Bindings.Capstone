namespace AssetRipper.Bindings.Capstone;

public enum aarch64_db
{
    AARCH64_DB_ISH = 0xb,
    AARCH64_DB_ISHLD = 0x9,
    AARCH64_DB_ISHST = 0xa,
    AARCH64_DB_LD = 0xd,
    AARCH64_DB_NSH = 0x7,
    AARCH64_DB_NSHLD = 0x5,
    AARCH64_DB_NSHST = 0x6,
    AARCH64_DB_OSH = 0x3,
    AARCH64_DB_OSHLD = 0x1,
    AARCH64_DB_OSHST = 0x2,
    AARCH64_DB_ST = 0xe,
    AARCH64_DB_SY = 0xf,
    AARCH64_DB_ENDING,
}
