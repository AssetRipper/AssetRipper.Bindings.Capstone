using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_systemz
{
    public systemz_cc cc;

    public systemz_insn_form format;

    [NativeTypeName("uint8_t")]
    public byte op_count;

    [NativeTypeName("cs_systemz_op[6]")]
    public _operands_e__FixedBuffer operands;

    [InlineArray(6)]
    public partial struct _operands_e__FixedBuffer
    {
        public cs_systemz_op e0;
    }
}
