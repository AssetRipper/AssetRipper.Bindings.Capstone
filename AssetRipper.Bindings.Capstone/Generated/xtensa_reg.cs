namespace AssetRipper.Bindings.Capstone;

public enum xtensa_reg
{
    XTENSA_REG_INVALID = 0,
    XTENSA_REG_ACCHI = 1,
    XTENSA_REG_ACCLO = 2,
    XTENSA_REG_ACCX = 3,
    XTENSA_REG_ATOMCTL = 4,
    XTENSA_REG_BREG = 5,
    XTENSA_REG_CCOUNT = 6,
    XTENSA_REG_CPENABLE = 7,
    XTENSA_REG_DDR = 8,
    XTENSA_REG_DEBUGCAUSE = 9,
    XTENSA_REG_DEPC = 10,
    XTENSA_REG_EXCCAUSE = 11,
    XTENSA_REG_EXCVADDR = 12,
    XTENSA_REG_EXPSTATE = 13,
    XTENSA_REG_FCR = 14,
    XTENSA_REG_FFT_BIT_WIDTH = 15,
    XTENSA_REG_FSR = 16,
    XTENSA_REG_GPIO_OUT = 17,
    XTENSA_REG_IBREAKENABLE = 18,
    XTENSA_REG_ICOUNT = 19,
    XTENSA_REG_ICOUNTLEVEL = 20,
    XTENSA_REG_INTCLEAR = 21,
    XTENSA_REG_INTENABLE = 22,
    XTENSA_REG_INTERRUPT = 23,
    XTENSA_REG_LBEG = 24,
    XTENSA_REG_LCOUNT = 25,
    XTENSA_REG_LEND = 26,
    XTENSA_REG_LITBASE = 27,
    XTENSA_REG_MEMCTL = 28,
    XTENSA_REG_PRID = 29,
    XTENSA_REG_PS = 30,
    XTENSA_REG_QACC = 31,
    XTENSA_REG_SAR = 32,
    XTENSA_REG_SAR_BYTE = 33,
    XTENSA_REG_SP = 34,
    XTENSA_REG_THREADPTR = 35,
    XTENSA_REG_UA_STATE = 36,
    XTENSA_REG_VECBASE = 37,
    XTENSA_REG_WINDOWBASE = 38,
    XTENSA_REG_WINDOWSTART = 39,
    XTENSA_REG_A0 = 40,
    XTENSA_REG_A2 = 41,
    XTENSA_REG_A3 = 42,
    XTENSA_REG_A4 = 43,
    XTENSA_REG_A5 = 44,
    XTENSA_REG_A6 = 45,
    XTENSA_REG_A7 = 46,
    XTENSA_REG_A8 = 47,
    XTENSA_REG_A9 = 48,
    XTENSA_REG_A10 = 49,
    XTENSA_REG_A11 = 50,
    XTENSA_REG_A12 = 51,
    XTENSA_REG_A13 = 52,
    XTENSA_REG_A14 = 53,
    XTENSA_REG_A15 = 54,
    XTENSA_REG_AED0 = 55,
    XTENSA_REG_AED1 = 56,
    XTENSA_REG_AED2 = 57,
    XTENSA_REG_AED3 = 58,
    XTENSA_REG_AED4 = 59,
    XTENSA_REG_AED5 = 60,
    XTENSA_REG_AED6 = 61,
    XTENSA_REG_AED7 = 62,
    XTENSA_REG_AED8 = 63,
    XTENSA_REG_AED9 = 64,
    XTENSA_REG_AED10 = 65,
    XTENSA_REG_AED11 = 66,
    XTENSA_REG_AED12 = 67,
    XTENSA_REG_AED13 = 68,
    XTENSA_REG_AED14 = 69,
    XTENSA_REG_AED15 = 70,
    XTENSA_REG_B0 = 71,
    XTENSA_REG_B1 = 72,
    XTENSA_REG_B2 = 73,
    XTENSA_REG_B3 = 74,
    XTENSA_REG_B4 = 75,
    XTENSA_REG_B5 = 76,
    XTENSA_REG_B6 = 77,
    XTENSA_REG_B7 = 78,
    XTENSA_REG_B8 = 79,
    XTENSA_REG_B9 = 80,
    XTENSA_REG_B10 = 81,
    XTENSA_REG_B11 = 82,
    XTENSA_REG_B12 = 83,
    XTENSA_REG_B13 = 84,
    XTENSA_REG_B14 = 85,
    XTENSA_REG_B15 = 86,
    XTENSA_REG_CCOMPARE0 = 87,
    XTENSA_REG_CCOMPARE1 = 88,
    XTENSA_REG_CCOMPARE2 = 89,
    XTENSA_REG_CONFIGID0 = 90,
    XTENSA_REG_CONFIGID1 = 91,
    XTENSA_REG_DBREAKA0 = 92,
    XTENSA_REG_DBREAKA1 = 93,
    XTENSA_REG_DBREAKC0 = 94,
    XTENSA_REG_DBREAKC1 = 95,
    XTENSA_REG_EPC1 = 96,
    XTENSA_REG_EPC2 = 97,
    XTENSA_REG_EPC3 = 98,
    XTENSA_REG_EPC4 = 99,
    XTENSA_REG_EPC5 = 100,
    XTENSA_REG_EPC6 = 101,
    XTENSA_REG_EPC7 = 102,
    XTENSA_REG_EPS2 = 103,
    XTENSA_REG_EPS3 = 104,
    XTENSA_REG_EPS4 = 105,
    XTENSA_REG_EPS5 = 106,
    XTENSA_REG_EPS6 = 107,
    XTENSA_REG_EPS7 = 108,
    XTENSA_REG_EXCSAVE1 = 109,
    XTENSA_REG_EXCSAVE2 = 110,
    XTENSA_REG_EXCSAVE3 = 111,
    XTENSA_REG_EXCSAVE4 = 112,
    XTENSA_REG_EXCSAVE5 = 113,
    XTENSA_REG_EXCSAVE6 = 114,
    XTENSA_REG_EXCSAVE7 = 115,
    XTENSA_REG_F0 = 116,
    XTENSA_REG_F1 = 117,
    XTENSA_REG_F2 = 118,
    XTENSA_REG_F3 = 119,
    XTENSA_REG_F4 = 120,
    XTENSA_REG_F5 = 121,
    XTENSA_REG_F6 = 122,
    XTENSA_REG_F7 = 123,
    XTENSA_REG_F8 = 124,
    XTENSA_REG_F9 = 125,
    XTENSA_REG_F10 = 126,
    XTENSA_REG_F11 = 127,
    XTENSA_REG_F12 = 128,
    XTENSA_REG_F13 = 129,
    XTENSA_REG_F14 = 130,
    XTENSA_REG_F15 = 131,
    XTENSA_REG_IBREAKA0 = 132,
    XTENSA_REG_IBREAKA1 = 133,
    XTENSA_REG_M0 = 134,
    XTENSA_REG_M1 = 135,
    XTENSA_REG_M2 = 136,
    XTENSA_REG_M3 = 137,
    XTENSA_REG_MISC0 = 138,
    XTENSA_REG_MISC1 = 139,
    XTENSA_REG_MISC2 = 140,
    XTENSA_REG_MISC3 = 141,
    XTENSA_REG_Q0 = 142,
    XTENSA_REG_Q1 = 143,
    XTENSA_REG_Q2 = 144,
    XTENSA_REG_Q3 = 145,
    XTENSA_REG_Q4 = 146,
    XTENSA_REG_Q5 = 147,
    XTENSA_REG_Q6 = 148,
    XTENSA_REG_Q7 = 149,
    XTENSA_REG_SCOMPARE1 = 150,
    XTENSA_REG_U0 = 151,
    XTENSA_REG_U1 = 152,
    XTENSA_REG_U2 = 153,
    XTENSA_REG_U3 = 154,
    XTENSA_REG_F64R_HI = 155,
    XTENSA_REG_F64R_LO = 156,
    XTENSA_REG_F64S = 157,
    XTENSA_REG_B0_B1 = 158,
    XTENSA_REG_B2_B3 = 159,
    XTENSA_REG_B4_B5 = 160,
    XTENSA_REG_B6_B7 = 161,
    XTENSA_REG_B8_B9 = 162,
    XTENSA_REG_B10_B11 = 163,
    XTENSA_REG_B12_B13 = 164,
    XTENSA_REG_B14_B15 = 165,
    XTENSA_REG_B0_B1_B2_B3 = 166,
    XTENSA_REG_B4_B5_B6_B7 = 167,
    XTENSA_REG_B8_B9_B10_B11 = 168,
    XTENSA_REG_B12_B13_B14_B15 = 169,
    XTENSA_REG_ENDING,
}
