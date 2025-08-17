namespace SharpFont.Interop;

internal partial struct FT_BitmapGlyphRec_
{
    [NativeTypeName("FT_GlyphRec")]
    public FT_GlyphRec_ root;

    [NativeTypeName("FT_Int")]
    public int left;

    [NativeTypeName("FT_Int")]
    public int top;

    [NativeTypeName("FT_Bitmap")]
    public FT_Bitmap_ bitmap;
}
