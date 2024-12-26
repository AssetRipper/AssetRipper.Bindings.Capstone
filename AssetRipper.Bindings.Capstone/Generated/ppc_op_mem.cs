namespace AssetRipper.Bindings.Capstone;

public partial struct ppc_op_mem
{
    public ppc_reg @base;

    [NativeTypeName("int32_t")]
    public int disp;

    public ppc_reg offset;
}
