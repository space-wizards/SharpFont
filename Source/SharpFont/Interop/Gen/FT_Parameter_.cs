namespace SharpFont.Interop;

internal unsafe partial struct FT_Parameter_
{
    [NativeTypeName("FT_ULong")]
    public nuint tag;

    [NativeTypeName("FT_Pointer")]
    public void* data;
}
