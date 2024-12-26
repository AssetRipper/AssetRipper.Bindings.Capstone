namespace AssetRipper.Bindings.Capstone;

public enum wasm_insn_group
{
    WASM_GRP_INVALID = 0,
    WASM_GRP_NUMBERIC = 8,
    WASM_GRP_PARAMETRIC,
    WASM_GRP_VARIABLE,
    WASM_GRP_MEMORY,
    WASM_GRP_CONTROL,
    WASM_GRP_ENDING,
}
