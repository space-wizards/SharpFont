namespace SharpFont.Interop;

internal unsafe partial struct FT_CharMapRec_
{
    [NativeTypeName("FT_Face")]
    public FT_FaceRec_* face;

    [NativeTypeName("FT_Encoding")]
    public SharpFont.Encoding encoding;

    [NativeTypeName("FT_UShort")]
    public ushort platform_id;

    [NativeTypeName("FT_UShort")]
    public ushort encoding_id;
}
