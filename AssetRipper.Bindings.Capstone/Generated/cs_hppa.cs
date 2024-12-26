using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_hppa
{
    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_hppa_op[5]")]
    public _operands_e__FixedBuffer operands;

    [InlineArray(5)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_hppa_op e0;
    }
}
