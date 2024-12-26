namespace AssetRipper.Bindings.Capstone;

public unsafe partial struct cs_opt_mnem
{
    [NativeTypeName("unsigned int")]
    public uint id;

    [NativeTypeName("const char *")]
    public sbyte* mnemonic;
}