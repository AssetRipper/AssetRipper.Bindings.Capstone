using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct hppa_ext
{
    [NativeTypeName("hppa_modifier[5]")]
    public _modifiers_e__FixedBuffer modifiers;

    [NativeTypeName("uint8_t")]
    public byte mod_num;

    public bool b_writeble;

    public bool is_alternative;

    [InlineArray(5)]
    public partial struct _modifiers_e__FixedBuffer
    {
        public hppa_modifier e0;
    }
}
