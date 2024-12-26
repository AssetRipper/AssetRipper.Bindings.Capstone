namespace AssetRipper.Bindings.Capstone;

public partial struct arm_sysop
{
    public arm_sysop_reg reg;

    public arm_spsr_cspr_bits psr_bits;

    [NativeTypeName("uint16_t")]
    public ushort sysm;

    [NativeTypeName("uint8_t")]
    public byte msr_mask;
}
