namespace AssetRipper.Bindings.Capstone;

public partial struct bpf_op_mem
{
    public bpf_reg @base;

    [NativeTypeName("uint32_t")]
    public uint disp;
}
