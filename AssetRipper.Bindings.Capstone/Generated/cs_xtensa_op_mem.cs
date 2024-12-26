namespace AssetRipper.Bindings.Capstone;

public partial struct cs_xtensa_op_mem
{
    [NativeTypeName("uint8_t")]
    public byte @base;

    [NativeTypeName("int32_t")]
    public int disp;
}
