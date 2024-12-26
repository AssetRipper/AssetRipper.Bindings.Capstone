using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_x86_op
{
    public x86_op_type type;

    [NativeTypeName("__AnonymousRecord_x86_L279_C2")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("uint8_t")]
    public byte size;

    [NativeTypeName("uint8_t")]
    public byte access;

    public x86_avx_bcast avx_bcast;

    public bool avx_zero_opmask;

    [UnscopedRef]
    public ref x86_reg reg
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
    public ref x86_op_mem mem
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
        public x86_reg reg;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long imm;

        [FieldOffset(0)]
        public x86_op_mem mem;
    }
}
