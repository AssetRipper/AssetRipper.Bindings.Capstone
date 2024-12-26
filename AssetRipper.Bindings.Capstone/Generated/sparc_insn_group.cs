namespace AssetRipper.Bindings.Capstone;

public enum sparc_insn_group
{
    SPARC_GRP_INVALID = 0,
    SPARC_GRP_JUMP,
    SPARC_GRP_HARDQUAD = 128,
    SPARC_GRP_V9,
    SPARC_GRP_VIS,
    SPARC_GRP_VIS2,
    SPARC_GRP_VIS3,
    SPARC_GRP_32BIT,
    SPARC_GRP_64BIT,
    SPARC_GRP_ENDING,
}
