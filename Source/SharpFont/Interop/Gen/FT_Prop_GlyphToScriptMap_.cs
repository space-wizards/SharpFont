namespace SharpFont.Interop;

internal unsafe partial struct FT_Prop_GlyphToScriptMap_
{
    [NativeTypeName("FT_Face")]
    public FT_FaceRec_* face;

    [NativeTypeName("FT_UShort *")]
    public ushort* map;
}
