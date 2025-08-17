namespace SharpFont.Interop;

internal partial struct FT_OutlineGlyphRec_
{
    [NativeTypeName("FT_GlyphRec")]
    public FT_GlyphRec_ root;

    [NativeTypeName("FT_Outline")]
    public FT_Outline_ outline;
}
