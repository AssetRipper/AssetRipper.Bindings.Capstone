using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_loongarch
{
    public loongarch_insn_form format;

    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_loongarch_op[8]")]
    public _operands_e__FixedBuffer operands;

    [InlineArray(8)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_loongarch_op e0;
    }
}
