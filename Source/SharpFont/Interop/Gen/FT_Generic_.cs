namespace SharpFont.Interop;

internal unsafe partial struct FT_Generic_
{
    public void* data;

    [NativeTypeName("FT_Generic_Finalizer")]
    public delegate* unmanaged[Cdecl]<void*, void> finalizer;
}
