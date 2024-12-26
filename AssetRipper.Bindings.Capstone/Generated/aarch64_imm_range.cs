namespace AssetRipper.Bindings.Capstone;

public partial struct aarch64_imm_range
{
    [NativeTypeName("uint8_t")]
    public byte first;

    [NativeTypeName("uint8_t")]
    public byte offset;
}
