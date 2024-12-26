using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_alpha_op
{
    public alpha_op_type type;

    [NativeTypeName("__AnonymousRecord_alpha_L34_C2")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("enum cs_ac_type")]
    public cs_ac_type access;

    [UnscopedRef]
    public ref uint reg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reg;
        }
    }

    [UnscopedRef]
    public ref int imm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.imm;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("unsigned int")]
        public uint reg;

        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public int imm;
    }
}
