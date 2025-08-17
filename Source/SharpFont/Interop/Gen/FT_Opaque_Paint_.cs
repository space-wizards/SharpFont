namespace SharpFont.Interop;

internal unsafe partial struct FT_Opaque_Paint_
{
    [NativeTypeName("FT_Byte *")]
    public byte* p;

    [NativeTypeName("FT_Bool")]
    public byte insert_root_transform;
}
