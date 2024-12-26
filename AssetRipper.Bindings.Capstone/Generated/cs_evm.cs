namespace AssetRipper.Bindings.Capstone;

public partial struct cs_evm
{
    [NativeTypeName("unsigned char")]
    public byte pop;

    [NativeTypeName("unsigned char")]
    public byte push;

    [NativeTypeName("unsigned int")]
    public uint fee;
}
