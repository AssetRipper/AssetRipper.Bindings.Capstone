using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_xtensa_operand
{
    [NativeTypeName("uint8_t")]
    public byte type;

    [NativeTypeName("uint8_t")]
    public byte access;

    [NativeTypeName("__AnonymousRecord_xtensa_L1708_C2")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref byte reg
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

    [UnscopedRef]
    public ref cs_xtensa_op_mem mem
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
        [NativeTypeName("uint8_t")]
        public byte reg;

        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public int imm;

        [FieldOffset(0)]
        public cs_xtensa_op_mem mem;
    }
}
