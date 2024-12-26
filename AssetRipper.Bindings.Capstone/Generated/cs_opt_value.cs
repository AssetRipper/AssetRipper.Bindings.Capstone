namespace AssetRipper.Bindings.Capstone;

public enum cs_opt_value
{
    CS_OPT_OFF = 0,
    CS_OPT_ON = 1 << 0,
    CS_OPT_SYNTAX_DEFAULT = 1 << 1,
    CS_OPT_SYNTAX_INTEL = 1 << 2,
    CS_OPT_SYNTAX_ATT = 1 << 3,
    CS_OPT_SYNTAX_NOREGNAME = 1 << 4,
    CS_OPT_SYNTAX_MASM = 1 << 5,
    CS_OPT_SYNTAX_MOTOROLA = 1 << 6,
    CS_OPT_SYNTAX_CS_REG_ALIAS = 1 << 7,
    CS_OPT_SYNTAX_PERCENT = 1 << 8,
    CS_OPT_SYNTAX_NO_DOLLAR = 1 << 9,
    CS_OPT_DETAIL_REAL = 1 << 1,
}
