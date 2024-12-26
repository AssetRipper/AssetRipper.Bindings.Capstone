namespace AssetRipper.Bindings.Capstone;

public enum sparc_hint
{
    SPARC_HINT_INVALID = 0,
    SPARC_HINT_A = 1 << 0,
    SPARC_HINT_PT = 1 << 1,
    SPARC_HINT_PN = 1 << 2,
    SPARC_HINT_A_PN = SPARC_HINT_A | SPARC_HINT_PN,
    SPARC_HINT_A_PT = SPARC_HINT_A | SPARC_HINT_PT,
}
