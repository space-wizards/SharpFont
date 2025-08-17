namespace SharpFont.Interop;

internal unsafe partial struct FT_SizeRec_
{
    [NativeTypeName("FT_Face")]
    public FT_FaceRec_* face;

    [NativeTypeName("FT_Generic")]
    public FT_Generic_ generic;

    [NativeTypeName("FT_Size_Metrics")]
    public FT_Size_Metrics_ metrics;

    [NativeTypeName("FT_Size_Internal")]
    public FT_Size_InternalRec_* @internal;
}
