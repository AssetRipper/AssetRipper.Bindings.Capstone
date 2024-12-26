namespace AssetRipper.Bindings.Capstone;

public enum evm_insn_group
{
    EVM_GRP_INVALID = 0,
    EVM_GRP_JUMP,
    EVM_GRP_MATH = 8,
    EVM_GRP_STACK_WRITE,
    EVM_GRP_STACK_READ,
    EVM_GRP_MEM_WRITE,
    EVM_GRP_MEM_READ,
    EVM_GRP_STORE_WRITE,
    EVM_GRP_STORE_READ,
    EVM_GRP_HALT,
    EVM_GRP_ENDING,
}
