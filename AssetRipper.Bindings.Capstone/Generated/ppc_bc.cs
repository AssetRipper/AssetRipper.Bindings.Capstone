namespace AssetRipper.Bindings.Capstone;

public partial struct ppc_bc
{
    [NativeTypeName("uint8_t")]
    public byte bo;

    [NativeTypeName("uint8_t")]
    public byte bi;

    public ppc_cr_bit crX_bit;

    public ppc_reg crX;

    public ppc_br_hint hint;

    public ppc_pred pred_cr;

    public ppc_pred pred_ctr;

    public ppc_bh bh;
}
