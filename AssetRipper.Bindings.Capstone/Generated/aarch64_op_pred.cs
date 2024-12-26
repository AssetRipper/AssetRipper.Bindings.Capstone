namespace AssetRipper.Bindings.Capstone;

public partial struct aarch64_op_pred
{
    public aarch64_reg reg;

    public aarch64_reg vec_select;

    [NativeTypeName("int32_t")]
    public int imm_index;
}
