namespace SharpFont.Interop;

internal unsafe partial struct FT_MemoryRec_
{
    public void* user;

    [NativeTypeName("FT_Alloc_Func")]
    public delegate* unmanaged[Cdecl]<FT_MemoryRec_*, int, void*> alloc;

    [NativeTypeName("FT_Free_Func")]
    public delegate* unmanaged[Cdecl]<FT_MemoryRec_*, void*, void> free;

    [NativeTypeName("FT_Realloc_Func")]
    public delegate* unmanaged[Cdecl]<FT_MemoryRec_*, int, int, void*, void*> realloc;
}
