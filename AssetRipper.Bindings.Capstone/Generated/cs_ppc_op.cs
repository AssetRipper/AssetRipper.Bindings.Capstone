using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_ppc_op
{
    public ppc_op_type type;

    [NativeTypeName("__AnonymousRecord_ppc_L826_C2")]
    public _Anonymous_e__Union Anonymous;

    public cs_ac_type access;

    [UnscopedRef]
    public ref ppc_reg reg
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
    public ref ppc_op_mem mem
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
        public ppc_reg reg;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long imm;

        [FieldOffset(0)]
        public ppc_op_mem mem;
    }
}
