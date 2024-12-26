namespace AssetRipper.Bindings.Capstone;

public partial struct aarch64_op_mem
{
    public aarch64_reg @base;

    public aarch64_reg index;

    [NativeTypeName("int32_t")]
    public int disp;
}
