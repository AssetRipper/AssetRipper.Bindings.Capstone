using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_xtensa
{
    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_xtensa_op[8]")]
    public _operands_e__FixedBuffer operands;

    public xtensa_insn_form format;

    [InlineArray(8)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_xtensa_operand e0;
    }
}
