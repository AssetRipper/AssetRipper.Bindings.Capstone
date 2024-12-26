using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_arm_op
{
    public int vector_index;

    [NativeTypeName("__AnonymousRecord_arm_L867_C2")]
    public _shift_e__Struct shift;

    public arm_op_type type;

    [NativeTypeName("__AnonymousRecord_arm_L874_C2")]
    public _Anonymous_e__Union Anonymous;

    public bool subtracted;

    [NativeTypeName("uint8_t")]
    public byte access;

    [NativeTypeName("int8_t")]
    public sbyte neon_lane;

    [UnscopedRef]
    public ref int reg
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reg;
        }
    }

    [UnscopedRef]
    public ref arm_sysop sysop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.sysop;
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
    public ref int pred
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pred;
        }
    }

    [UnscopedRef]
    public ref double fp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.fp;
        }
    }

    [UnscopedRef]
    public ref arm_op_mem mem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.mem;
        }
    }

    [UnscopedRef]
    public ref arm_setend_type setend
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.setend;
        }
    }

    public partial struct _shift_e__Struct
    {
        public arm_shifter type;

        [NativeTypeName("unsigned int")]
        public uint value;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public int reg;

        [FieldOffset(0)]
        public arm_sysop sysop;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long imm;

        [FieldOffset(0)]
        public int pred;

        [FieldOffset(0)]
        public double fp;

        [FieldOffset(0)]
        public arm_op_mem mem;

        [FieldOffset(0)]
        public arm_setend_type setend;
    }
}
