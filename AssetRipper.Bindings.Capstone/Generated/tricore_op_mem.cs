namespace AssetRipper.Bindings.Capstone;

public partial struct tricore_op_mem
{
    [NativeTypeName("uint8_t")]
    public byte @base;

    [NativeTypeName("int64_t")]
    public long disp;
}
