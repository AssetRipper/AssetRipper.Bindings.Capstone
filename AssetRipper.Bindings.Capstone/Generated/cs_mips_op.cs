using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct cs_mips_op
{
    public mips_op_type type;

    [NativeTypeName("__AnonymousRecord_mips_L685_C2")]
    public _Anonymous_e__Union Anonymous;

    public bool is_reglist;

    public bool is_unsigned;

    [NativeTypeName("uint8_t")]
    public byte access;

    [UnscopedRef]
    public ref mips_reg reg
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
    public ref ulong uimm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.uimm;
        }
    }

    [UnscopedRef]
    public ref mips_op_mem mem
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
        public mips_reg reg;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long imm;

        [FieldOffset(0)]
        [NativeTypeName("uint64_t")]
        public ulong uimm;

        [FieldOffset(0)]
        public mips_op_mem mem;
    }
}
