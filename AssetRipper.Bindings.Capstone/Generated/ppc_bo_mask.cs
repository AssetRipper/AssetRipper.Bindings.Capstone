namespace AssetRipper.Bindings.Capstone;

public enum ppc_bo_mask
{
    PPC_BO_TEST_CR = (1 << 4),
    PPC_BO_CR_CMP = (1 << 3),
    PPC_BO_DECR_CTR = (1 << 2),
    PPC_BO_CTR_CMP = (1 << 1),
    PPC_BO_T = 1,
}
