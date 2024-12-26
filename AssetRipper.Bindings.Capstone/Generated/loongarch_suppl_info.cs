namespace AssetRipper.Bindings.Capstone;

public partial struct loongarch_suppl_info
{
    public loongarch_insn_form form;

    [NativeTypeName("enum cs_ac_type")]
    public cs_ac_type memory_access;
}
