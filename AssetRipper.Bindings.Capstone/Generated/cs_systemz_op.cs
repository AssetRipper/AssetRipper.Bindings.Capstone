using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_systemz_op
{
    public systemz_op_type type;

    [NativeTypeName("__AnonymousRecord_systemz_L368_C2")]
    public _Anonymous_e__Union Anonymous;

    public cs_ac_type access;

    [NativeTypeName("uint8_t")]
    public byte imm_width;

    [UnscopedRef]
    public ref systemz_reg reg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reg;
        }
    }

    [UnscopedRef]
    public ref long imm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.imm;
        }
    }

    [UnscopedRef]
    public ref systemz_op_mem mem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.mem;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public systemz_reg reg;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long imm;

        [FieldOffset(0)]
        public systemz_op_mem mem;
    }
}
