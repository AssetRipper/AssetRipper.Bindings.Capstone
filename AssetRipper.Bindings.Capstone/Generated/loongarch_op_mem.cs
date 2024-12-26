namespace AssetRipper.Bindings.Capstone;

public partial struct loongarch_op_mem
{
    [NativeTypeName("unsigned int")]
    public uint @base;

    [NativeTypeName("unsigned int")]
    public uint index;

    [NativeTypeName("int64_t")]
    public long disp;
}
