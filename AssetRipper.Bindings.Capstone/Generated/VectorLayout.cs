namespace AssetRipper.Bindings.Capstone;

public enum VectorLayout
{
    AARCH64LAYOUT_INVALID = 0,
    AARCH64LAYOUT_VL_B = 8,
    AARCH64LAYOUT_VL_H = 16,
    AARCH64LAYOUT_VL_S = 32,
    AARCH64LAYOUT_VL_D = 64,
    AARCH64LAYOUT_VL_Q = 128,
    AARCH64LAYOUT_VL_4B = (4 << 8) | AARCH64LAYOUT_VL_B,
    AARCH64LAYOUT_VL_2H = (2 << 8) | AARCH64LAYOUT_VL_H,
    AARCH64LAYOUT_VL_1S = (1 << 8) | AARCH64LAYOUT_VL_S,
    AARCH64LAYOUT_VL_8B = (8 << 8) | AARCH64LAYOUT_VL_B,
    AARCH64LAYOUT_VL_4H = (4 << 8) | AARCH64LAYOUT_VL_H,
    AARCH64LAYOUT_VL_2S = (2 << 8) | AARCH64LAYOUT_VL_S,
    AARCH64LAYOUT_VL_1D = (1 << 8) | AARCH64LAYOUT_VL_D,
    AARCH64LAYOUT_VL_16B = (16 << 8) | AARCH64LAYOUT_VL_B,
    AARCH64LAYOUT_VL_8H = (8 << 8) | AARCH64LAYOUT_VL_H,
    AARCH64LAYOUT_VL_4S = (4 << 8) | AARCH64LAYOUT_VL_S,
    AARCH64LAYOUT_VL_2D = (2 << 8) | AARCH64LAYOUT_VL_D,
    AARCH64LAYOUT_VL_1Q = (1 << 8) | AARCH64LAYOUT_VL_Q,
    AARCH64LAYOUT_VL_64B = (64 << 8) | AARCH64LAYOUT_VL_B,
    AARCH64LAYOUT_VL_32H = (32 << 8) | AARCH64LAYOUT_VL_H,
    AARCH64LAYOUT_VL_16S = (16 << 8) | AARCH64LAYOUT_VL_S,
    AARCH64LAYOUT_VL_8D = (8 << 8) | AARCH64LAYOUT_VL_D,
    AARCH64LAYOUT_VL_COMPLETE,
}
