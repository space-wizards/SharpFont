namespace SharpFont.Interop;

internal unsafe partial struct FTC_ImageTypeRec_
{
    [NativeTypeName("FTC_FaceID")]
    public void* face_id;

    [NativeTypeName("FT_UInt")]
    public uint width;

    [NativeTypeName("FT_UInt")]
    public uint height;

    [NativeTypeName("FT_Int32")]
    public int flags;
}
