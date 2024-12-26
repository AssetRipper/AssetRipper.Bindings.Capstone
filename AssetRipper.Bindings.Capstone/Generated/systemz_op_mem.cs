namespace AssetRipper.Bindings.Capstone;

public partial struct systemz_op_mem
{
    public systemz_addr_mode am;

    [NativeTypeName("uint8_t")]
    public byte @base;

    [NativeTypeName("uint8_t")]
    public byte index;

    [NativeTypeName("uint64_t")]
    public ulong length;

    [NativeTypeName("int64_t")]
    public long disp;
}
