namespace AssetRipper.Bindings.Capstone;

public partial struct riscv_op_mem
{
    [NativeTypeName("unsigned int")]
    public uint @base;

    [NativeTypeName("int64_t")]
    public long disp;
}
