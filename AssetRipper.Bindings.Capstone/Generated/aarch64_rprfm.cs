namespace AssetRipper.Bindings.Capstone;

public enum aarch64_rprfm
{
    AARCH64_RPRFM_PLDKEEP = 0x0,
    AARCH64_RPRFM_PLDSTRM = 0x4,
    AARCH64_RPRFM_PSTKEEP = 0x1,
    AARCH64_RPRFM_PSTSTRM = 0x5,
    AARCH64_RPRFM_ENDING,
}
