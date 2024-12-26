namespace AssetRipper.Bindings.Capstone;

public enum loongarch_reg
{
    LOONGARCH_REG_INVALID = 0,
    LOONGARCH_REG_F0 = 1,
    LOONGARCH_REG_F1 = 2,
    LOONGARCH_REG_F2 = 3,
    LOONGARCH_REG_F3 = 4,
    LOONGARCH_REG_F4 = 5,
    LOONGARCH_REG_F5 = 6,
    LOONGARCH_REG_F6 = 7,
    LOONGARCH_REG_F7 = 8,
    LOONGARCH_REG_F8 = 9,
    LOONGARCH_REG_F9 = 10,
    LOONGARCH_REG_F10 = 11,
    LOONGARCH_REG_F11 = 12,
    LOONGARCH_REG_F12 = 13,
    LOONGARCH_REG_F13 = 14,
    LOONGARCH_REG_F14 = 15,
    LOONGARCH_REG_F15 = 16,
    LOONGARCH_REG_F16 = 17,
    LOONGARCH_REG_F17 = 18,
    LOONGARCH_REG_F18 = 19,
    LOONGARCH_REG_F19 = 20,
    LOONGARCH_REG_F20 = 21,
    LOONGARCH_REG_F21 = 22,
    LOONGARCH_REG_F22 = 23,
    LOONGARCH_REG_F23 = 24,
    LOONGARCH_REG_F24 = 25,
    LOONGARCH_REG_F25 = 26,
    LOONGARCH_REG_F26 = 27,
    LOONGARCH_REG_F27 = 28,
    LOONGARCH_REG_F28 = 29,
    LOONGARCH_REG_F29 = 30,
    LOONGARCH_REG_F30 = 31,
    LOONGARCH_REG_F31 = 32,
    LOONGARCH_REG_FCC0 = 33,
    LOONGARCH_REG_FCC1 = 34,
    LOONGARCH_REG_FCC2 = 35,
    LOONGARCH_REG_FCC3 = 36,
    LOONGARCH_REG_FCC4 = 37,
    LOONGARCH_REG_FCC5 = 38,
    LOONGARCH_REG_FCC6 = 39,
    LOONGARCH_REG_FCC7 = 40,
    LOONGARCH_REG_FCSR0 = 41,
    LOONGARCH_REG_FCSR1 = 42,
    LOONGARCH_REG_FCSR2 = 43,
    LOONGARCH_REG_FCSR3 = 44,
    LOONGARCH_REG_R0 = 45,
    LOONGARCH_REG_R1 = 46,
    LOONGARCH_REG_R2 = 47,
    LOONGARCH_REG_R3 = 48,
    LOONGARCH_REG_R4 = 49,
    LOONGARCH_REG_R5 = 50,
    LOONGARCH_REG_R6 = 51,
    LOONGARCH_REG_R7 = 52,
    LOONGARCH_REG_R8 = 53,
    LOONGARCH_REG_R9 = 54,
    LOONGARCH_REG_R10 = 55,
    LOONGARCH_REG_R11 = 56,
    LOONGARCH_REG_R12 = 57,
    LOONGARCH_REG_R13 = 58,
    LOONGARCH_REG_R14 = 59,
    LOONGARCH_REG_R15 = 60,
    LOONGARCH_REG_R16 = 61,
    LOONGARCH_REG_R17 = 62,
    LOONGARCH_REG_R18 = 63,
    LOONGARCH_REG_R19 = 64,
    LOONGARCH_REG_R20 = 65,
    LOONGARCH_REG_R21 = 66,
    LOONGARCH_REG_R22 = 67,
    LOONGARCH_REG_R23 = 68,
    LOONGARCH_REG_R24 = 69,
    LOONGARCH_REG_R25 = 70,
    LOONGARCH_REG_R26 = 71,
    LOONGARCH_REG_R27 = 72,
    LOONGARCH_REG_R28 = 73,
    LOONGARCH_REG_R29 = 74,
    LOONGARCH_REG_R30 = 75,
    LOONGARCH_REG_R31 = 76,
    LOONGARCH_REG_SCR0 = 77,
    LOONGARCH_REG_SCR1 = 78,
    LOONGARCH_REG_SCR2 = 79,
    LOONGARCH_REG_SCR3 = 80,
    LOONGARCH_REG_VR0 = 81,
    LOONGARCH_REG_VR1 = 82,
    LOONGARCH_REG_VR2 = 83,
    LOONGARCH_REG_VR3 = 84,
    LOONGARCH_REG_VR4 = 85,
    LOONGARCH_REG_VR5 = 86,
    LOONGARCH_REG_VR6 = 87,
    LOONGARCH_REG_VR7 = 88,
    LOONGARCH_REG_VR8 = 89,
    LOONGARCH_REG_VR9 = 90,
    LOONGARCH_REG_VR10 = 91,
    LOONGARCH_REG_VR11 = 92,
    LOONGARCH_REG_VR12 = 93,
    LOONGARCH_REG_VR13 = 94,
    LOONGARCH_REG_VR14 = 95,
    LOONGARCH_REG_VR15 = 96,
    LOONGARCH_REG_VR16 = 97,
    LOONGARCH_REG_VR17 = 98,
    LOONGARCH_REG_VR18 = 99,
    LOONGARCH_REG_VR19 = 100,
    LOONGARCH_REG_VR20 = 101,
    LOONGARCH_REG_VR21 = 102,
    LOONGARCH_REG_VR22 = 103,
    LOONGARCH_REG_VR23 = 104,
    LOONGARCH_REG_VR24 = 105,
    LOONGARCH_REG_VR25 = 106,
    LOONGARCH_REG_VR26 = 107,
    LOONGARCH_REG_VR27 = 108,
    LOONGARCH_REG_VR28 = 109,
    LOONGARCH_REG_VR29 = 110,
    LOONGARCH_REG_VR30 = 111,
    LOONGARCH_REG_VR31 = 112,
    LOONGARCH_REG_XR0 = 113,
    LOONGARCH_REG_XR1 = 114,
    LOONGARCH_REG_XR2 = 115,
    LOONGARCH_REG_XR3 = 116,
    LOONGARCH_REG_XR4 = 117,
    LOONGARCH_REG_XR5 = 118,
    LOONGARCH_REG_XR6 = 119,
    LOONGARCH_REG_XR7 = 120,
    LOONGARCH_REG_XR8 = 121,
    LOONGARCH_REG_XR9 = 122,
    LOONGARCH_REG_XR10 = 123,
    LOONGARCH_REG_XR11 = 124,
    LOONGARCH_REG_XR12 = 125,
    LOONGARCH_REG_XR13 = 126,
    LOONGARCH_REG_XR14 = 127,
    LOONGARCH_REG_XR15 = 128,
    LOONGARCH_REG_XR16 = 129,
    LOONGARCH_REG_XR17 = 130,
    LOONGARCH_REG_XR18 = 131,
    LOONGARCH_REG_XR19 = 132,
    LOONGARCH_REG_XR20 = 133,
    LOONGARCH_REG_XR21 = 134,
    LOONGARCH_REG_XR22 = 135,
    LOONGARCH_REG_XR23 = 136,
    LOONGARCH_REG_XR24 = 137,
    LOONGARCH_REG_XR25 = 138,
    LOONGARCH_REG_XR26 = 139,
    LOONGARCH_REG_XR27 = 140,
    LOONGARCH_REG_XR28 = 141,
    LOONGARCH_REG_XR29 = 142,
    LOONGARCH_REG_XR30 = 143,
    LOONGARCH_REG_XR31 = 144,
    LOONGARCH_REG_F0_64 = 145,
    LOONGARCH_REG_F1_64 = 146,
    LOONGARCH_REG_F2_64 = 147,
    LOONGARCH_REG_F3_64 = 148,
    LOONGARCH_REG_F4_64 = 149,
    LOONGARCH_REG_F5_64 = 150,
    LOONGARCH_REG_F6_64 = 151,
    LOONGARCH_REG_F7_64 = 152,
    LOONGARCH_REG_F8_64 = 153,
    LOONGARCH_REG_F9_64 = 154,
    LOONGARCH_REG_F10_64 = 155,
    LOONGARCH_REG_F11_64 = 156,
    LOONGARCH_REG_F12_64 = 157,
    LOONGARCH_REG_F13_64 = 158,
    LOONGARCH_REG_F14_64 = 159,
    LOONGARCH_REG_F15_64 = 160,
    LOONGARCH_REG_F16_64 = 161,
    LOONGARCH_REG_F17_64 = 162,
    LOONGARCH_REG_F18_64 = 163,
    LOONGARCH_REG_F19_64 = 164,
    LOONGARCH_REG_F20_64 = 165,
    LOONGARCH_REG_F21_64 = 166,
    LOONGARCH_REG_F22_64 = 167,
    LOONGARCH_REG_F23_64 = 168,
    LOONGARCH_REG_F24_64 = 169,
    LOONGARCH_REG_F25_64 = 170,
    LOONGARCH_REG_F26_64 = 171,
    LOONGARCH_REG_F27_64 = 172,
    LOONGARCH_REG_F28_64 = 173,
    LOONGARCH_REG_F29_64 = 174,
    LOONGARCH_REG_F30_64 = 175,
    LOONGARCH_REG_F31_64 = 176,
    LOONGARCH_REG_ENDING,
    LOONGARCH_REG_ZERO = LOONGARCH_REG_R0,
    LOONGARCH_REG_RA = LOONGARCH_REG_R1,
    LOONGARCH_REG_TP = LOONGARCH_REG_R2,
    LOONGARCH_REG_SP = LOONGARCH_REG_R3,
    LOONGARCH_REG_A0 = LOONGARCH_REG_R4,
    LOONGARCH_REG_A1 = LOONGARCH_REG_R5,
    LOONGARCH_REG_A2 = LOONGARCH_REG_R6,
    LOONGARCH_REG_A3 = LOONGARCH_REG_R7,
    LOONGARCH_REG_A4 = LOONGARCH_REG_R8,
    LOONGARCH_REG_A5 = LOONGARCH_REG_R9,
    LOONGARCH_REG_A6 = LOONGARCH_REG_R10,
    LOONGARCH_REG_A7 = LOONGARCH_REG_R11,
    LOONGARCH_REG_T0 = LOONGARCH_REG_R12,
    LOONGARCH_REG_T1 = LOONGARCH_REG_R13,
    LOONGARCH_REG_T2 = LOONGARCH_REG_R14,
    LOONGARCH_REG_T3 = LOONGARCH_REG_R15,
    LOONGARCH_REG_T4 = LOONGARCH_REG_R16,
    LOONGARCH_REG_T5 = LOONGARCH_REG_R17,
    LOONGARCH_REG_T6 = LOONGARCH_REG_R18,
    LOONGARCH_REG_T7 = LOONGARCH_REG_R19,
    LOONGARCH_REG_T8 = LOONGARCH_REG_R20,
    LOONGARCH_REG_FP = LOONGARCH_REG_R22,
    LOONGARCH_REG_S9 = LOONGARCH_REG_R22,
    LOONGARCH_REG_S0 = LOONGARCH_REG_R23,
    LOONGARCH_REG_S1 = LOONGARCH_REG_R24,
    LOONGARCH_REG_S2 = LOONGARCH_REG_R25,
    LOONGARCH_REG_S3 = LOONGARCH_REG_R26,
    LOONGARCH_REG_S4 = LOONGARCH_REG_R27,
    LOONGARCH_REG_S5 = LOONGARCH_REG_R28,
    LOONGARCH_REG_S6 = LOONGARCH_REG_R29,
    LOONGARCH_REG_S7 = LOONGARCH_REG_R30,
    LOONGARCH_REG_S8 = LOONGARCH_REG_R31,
}