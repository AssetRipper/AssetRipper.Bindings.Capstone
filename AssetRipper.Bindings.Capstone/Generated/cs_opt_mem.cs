namespace AssetRipper.Bindings.Capstone;

public unsafe partial struct cs_opt_mem
{
    [NativeTypeName("cs_malloc_t")]
    public delegate* unmanaged[Cdecl]<nuint, void*> malloc;

    [NativeTypeName("cs_calloc_t")]
    public delegate* unmanaged[Cdecl]<nuint, nuint, void*> calloc;

    [NativeTypeName("cs_realloc_t")]
    public delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc;

    [NativeTypeName("cs_free_t")]
    public delegate* unmanaged[Cdecl]<void*, void> free;

    [NativeTypeName("cs_vsnprintf_t")]
    public delegate* unmanaged[Cdecl]<sbyte*, nuint, sbyte*, sbyte*, int> vsnprintf;
}
