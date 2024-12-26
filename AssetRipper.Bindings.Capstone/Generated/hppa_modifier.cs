using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.Capstone;

public partial struct hppa_modifier
{
    public hppa_modifier_type type;

    [NativeTypeName("__AnonymousRecord_hppa_L507_C2")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public Span<sbyte> str_mod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.str_mod;
        }
    }

    [UnscopedRef]
    public ref uint int_mod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.int_mod;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("char[8]")]
        public _str_mod_e__FixedBuffer str_mod;

        [FieldOffset(0)]
        [NativeTypeName("uint32_t")]
        public uint int_mod;

        [InlineArray(8)]
        public partial struct _str_mod_e__FixedBuffer
        {
            public sbyte e0;
        }
    }
}
