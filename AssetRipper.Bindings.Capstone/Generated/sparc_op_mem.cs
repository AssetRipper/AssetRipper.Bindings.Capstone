namespace AssetRipper.Bindings.Capstone;

public partial struct sparc_op_mem
{
    [NativeTypeName("uint8_t")]
    public byte @base;

    [NativeTypeName("uint8_t")]
    public byte index;

    [NativeTypeName("int32_t")]
    public int disp;
}