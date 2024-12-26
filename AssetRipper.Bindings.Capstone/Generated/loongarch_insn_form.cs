namespace AssetRipper.Bindings.Capstone;

public enum loongarch_insn_form
{
    LOONGARCH_INSN_FORM_PSEUDO,
    LOONGARCH_INSN_FORM_FMT3R,
    LOONGARCH_INSN_FORM_FMT2RI12,
    LOONGARCH_INSN_FORM_FMT2RI5,
    LOONGARCH_INSN_FORM_FMT2RI16,
    LOONGARCH_INSN_FORM_FMT3RI2,
    LOONGARCH_INSN_FORM_NODSTFMT2RI4,
    LOONGARCH_INSN_FORM_FMT1RI8,
    LOONGARCH_INSN_FORM_FMT2RI4,
    LOONGARCH_INSN_FORM_NODSTFMT1RI4,
    LOONGARCH_INSN_FORM_NODSTFMT1RI5I4,
    LOONGARCH_INSN_FORM_FMTASRT,
    LOONGARCH_INSN_FORM_FMTI26,
    LOONGARCH_INSN_FORM_FPFMTBR,
    LOONGARCH_INSN_FORM_FMT1RI21,
    LOONGARCH_INSN_FORM_FMT2R,
    LOONGARCH_INSN_FORM_FMTI15,
    LOONGARCH_INSN_FORM_FMTBSTR_D,
    LOONGARCH_INSN_FORM_FMTBSTR_W,
    LOONGARCH_INSN_FORM_FMT3RI3,
    LOONGARCH_INSN_FORM_FMTCACOP,
    LOONGARCH_INSN_FORM_FMTCSR,
    LOONGARCH_INSN_FORM_FMTCSRXCHG,
    LOONGARCH_INSN_FORM_FMTI32,
    LOONGARCH_INSN_FORM_FPFMT2R,
    LOONGARCH_INSN_FORM_FPFMT3R,
    LOONGARCH_INSN_FORM_FPFMTFCMP,
    LOONGARCH_INSN_FORM_FPFMTMEM,
    LOONGARCH_INSN_FORM_FPFMT2RI12,
    LOONGARCH_INSN_FORM_FPFMT4R,
    LOONGARCH_INSN_FORM_FPFMTMOV,
    LOONGARCH_INSN_FORM_FPFMTFSEL,
    LOONGARCH_INSN_FORM_FMTINVTLB,
    LOONGARCH_INSN_FORM_FMTJISCR,
    LOONGARCH_INSN_FORM_FMT2RI8,
    LOONGARCH_INSN_FORM_FMTLDPTE,
    LOONGARCH_INSN_FORM_FMT2RI14,
    LOONGARCH_INSN_FORM_FMT1RI20,
    LOONGARCH_INSN_FORM_FMTGR2SCR,
    LOONGARCH_INSN_FORM_FMTSCR2GR,
    LOONGARCH_INSN_FORM_FMTPRELD,
    LOONGARCH_INSN_FORM_FMTPRELDX,
    LOONGARCH_INSN_FORM_FMT2RI3,
    LOONGARCH_INSN_FORM_FMT2RI6,
    LOONGARCH_INSN_FORM_FMT1RI4,
    LOONGARCH_INSN_FORM_FMT3R_VVV,
    LOONGARCH_INSN_FORM_FMT2RI5_VVI,
    LOONGARCH_INSN_FORM_FMT2RI8_VVI,
    LOONGARCH_INSN_FORM_FMT2RI3_VVI,
    LOONGARCH_INSN_FORM_FMT2RI6_VVI,
    LOONGARCH_INSN_FORM_FMT2RI4_VVI,
    LOONGARCH_INSN_FORM_FMT4R_VVVV,
    LOONGARCH_INSN_FORM_FMT2R_VV,
    LOONGARCH_INSN_FORM_FMT2R_XX,
    LOONGARCH_INSN_FORM_FMT2RI4_VRI,
    LOONGARCH_INSN_FORM_FMT2RI1_VRI,
    LOONGARCH_INSN_FORM_FMT2RI3_VRI,
    LOONGARCH_INSN_FORM_FMT2RI2_VRI,
    LOONGARCH_INSN_FORM_FMT2RI12_VRI,
    LOONGARCH_INSN_FORM_FMT1RI13_VI,
    LOONGARCH_INSN_FORM_FMT2RI9_VRI,
    LOONGARCH_INSN_FORM_FMT2RI11_VRI,
    LOONGARCH_INSN_FORM_FMT2RI10_VRI,
    LOONGARCH_INSN_FORM_FMT3R_VRR,
    LOONGARCH_INSN_FORM_FMT2RI4_RVI,
    LOONGARCH_INSN_FORM_FMT2RI1_RVI,
    LOONGARCH_INSN_FORM_FMT2RI3_RVI,
    LOONGARCH_INSN_FORM_FMT2RI2_RVI,
    LOONGARCH_INSN_FORM_FMT2R_VR,
    LOONGARCH_INSN_FORM_FMT2RI1_VVI,
    LOONGARCH_INSN_FORM_FMT2RI2_VVI,
    LOONGARCH_INSN_FORM_FMT3R_VVR,
    LOONGARCH_INSN_FORM_FMT2R_CV,
    LOONGARCH_INSN_FORM_FMT2RI7_VVI,
    LOONGARCH_INSN_FORM_FMT2RI8I4_VRII,
    LOONGARCH_INSN_FORM_FMT2RI8I1_VRII,
    LOONGARCH_INSN_FORM_FMT2RI8I3_VRII,
    LOONGARCH_INSN_FORM_FMT2RI8I2_VRII,
    LOONGARCH_INSN_FORM_NODSTFMT2R,
    LOONGARCH_INSN_FORM_NODSTFMT1R,
    LOONGARCH_INSN_FORM_FMTMFTOP,
    LOONGARCH_INSN_FORM_FMTMTTOP,
    LOONGARCH_INSN_FORM_NODSTFMT1RI3,
    LOONGARCH_INSN_FORM_NODSTFMT1RI6,
    LOONGARCH_INSN_FORM_NODSTFMT1RI5,
    LOONGARCH_INSN_FORM_FMT1RI5I8,
    LOONGARCH_INSN_FORM_FMT3R_XXX,
    LOONGARCH_INSN_FORM_FMT2RI5_XXI,
    LOONGARCH_INSN_FORM_FMT2RI8_XXI,
    LOONGARCH_INSN_FORM_FMT2RI3_XXI,
    LOONGARCH_INSN_FORM_FMT2RI6_XXI,
    LOONGARCH_INSN_FORM_FMT2RI4_XXI,
    LOONGARCH_INSN_FORM_FMT4R_XXXX,
    LOONGARCH_INSN_FORM_FMT2RI2_XRI,
    LOONGARCH_INSN_FORM_FMT2RI3_XRI,
    LOONGARCH_INSN_FORM_FMT2RI2_XXI,
    LOONGARCH_INSN_FORM_FMT2RI12_XRI,
    LOONGARCH_INSN_FORM_FMT1RI13_XI,
    LOONGARCH_INSN_FORM_FMT2RI9_XRI,
    LOONGARCH_INSN_FORM_FMT2RI11_XRI,
    LOONGARCH_INSN_FORM_FMT2RI10_XRI,
    LOONGARCH_INSN_FORM_FMT3R_XRR,
    LOONGARCH_INSN_FORM_FMT2RI2_RXI,
    LOONGARCH_INSN_FORM_FMT2RI3_RXI,
    LOONGARCH_INSN_FORM_FMT2RI1_XXI,
    LOONGARCH_INSN_FORM_FMT2R_XR,
    LOONGARCH_INSN_FORM_FMT3R_XXR,
    LOONGARCH_INSN_FORM_FMT2R_CX,
    LOONGARCH_INSN_FORM_FMT2RI7_XXI,
    LOONGARCH_INSN_FORM_FMT2RI8I5_XRII,
    LOONGARCH_INSN_FORM_FMT2RI8I2_XRII,
    LOONGARCH_INSN_FORM_FMT2RI8I4_XRII,
    LOONGARCH_INSN_FORM_FMT2RI8I3_XRII,
}
