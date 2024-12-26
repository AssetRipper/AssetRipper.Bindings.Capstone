namespace AssetRipper.Bindings.Capstone;

public enum ppc_br_hint
{
    PPC_BR_NOT_GIVEN = 0x0,
    PPC_BR_RESERVED = 0x1,
    PPC_BR_NOT_TAKEN = 0x2,
    PPC_BR_TAKEN = 0x3,
    PPC_BR_HINT_MASK = 0x3,
}
