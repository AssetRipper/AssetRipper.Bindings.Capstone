using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_alpha
{
    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_alpha_op[3]")]
    public _operands_e__FixedBuffer operands;

    [InlineArray(3)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_alpha_op e0;
    }
}
