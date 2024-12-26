using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_aarch64_op
{
    public int vector_index;

    [NativeTypeName("AArch64Layout_VectorLayout")]
    public VectorLayout vas;

    [NativeTypeName("__AnonymousRecord_aarch64_L2814_C3")]
    public _shift_e__Struct shift;

    public aarch64_extender ext;

    public aarch64_op_type type;

    public bool is_vreg;

    [NativeTypeName("__AnonymousRecord_aarch64_L2823_C3")]
    public _Anonymous_e__Union Anonymous;

    public aarch64_sysop sysop;

    [NativeTypeName("uint8_t")]
    public byte access;

    public bool is_list_member;

    [UnscopedRef]
    public ref aarch64_reg reg
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
    public ref aarch64_imm_range imm_range
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.imm_range;
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
    public ref aarch64_op_mem mem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.mem;
        }
    }

    [UnscopedRef]
    public ref aarch64_op_sme sme
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.sme;
        }
    }

    [UnscopedRef]
    public ref aarch64_op_pred pred
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pred;
        }
    }

    public partial struct _shift_e__Struct
    {
        public aarch64_shifter type;

        [NativeTypeName("unsigned int")]
        public uint value;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public aarch64_reg reg;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long imm;

        [FieldOffset(0)]
        public aarch64_imm_range imm_range;

        [FieldOffset(0)]
        public double fp;

        [FieldOffset(0)]
        public aarch64_op_mem mem;

        [FieldOffset(0)]
        public aarch64_op_sme sme;

        [FieldOffset(0)]
        public aarch64_op_pred pred;
    }
}
