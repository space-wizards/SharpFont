namespace SharpFont.Interop;

internal unsafe partial struct FTC_ScalerRec_
{
    [NativeTypeName("FTC_FaceID")]
    public void* face_id;

    [NativeTypeName("FT_UInt")]
    public uint width;

    [NativeTypeName("FT_UInt")]
    public uint height;

    [NativeTypeName("FT_Int")]
    public int pixel;

    [NativeTypeName("FT_UInt")]
    public uint x_res;

    [NativeTypeName("FT_UInt")]
    public uint y_res;
}
