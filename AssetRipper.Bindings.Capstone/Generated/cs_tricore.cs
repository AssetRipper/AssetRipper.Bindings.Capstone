using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_tricore
{
    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_tricore_op[8]")]
    public _operands_e__FixedBuffer operands;

    public bool update_flags;

    [InlineArray(8)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_tricore_op e0;
    }
}
