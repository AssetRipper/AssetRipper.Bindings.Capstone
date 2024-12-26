namespace AssetRipper.Bindings.Capstone;

public enum hppa_insn_group
{
    HPPA_GRP_INVALID = 0,
    HPPA_GRP_COMPUTATION = 128,
    HPPA_GRP_MULTIMEDIA,
    HPPA_GRP_MEM_REF,
    HPPA_GRP_LONG_IMM,
    HPPA_GRP_BRANCH,
    HPPA_GRP_SYSCTRL,
    HPPA_GRP_ASSIST,
    HPPA_GRP_FLOAT,
    HPPA_GRP_PERFMON,
    HPPA_GRP_ENDING,
}
