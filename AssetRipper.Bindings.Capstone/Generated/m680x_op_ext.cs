namespace AssetRipper.Bindings.Capstone;

public partial struct m680x_op_ext
{
    [NativeTypeName("uint16_t")]
    public ushort address;

    public bool indirect;
}
