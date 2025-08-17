namespace SharpFont.Interop;

internal unsafe partial struct FT_Glyph_Class_
{
    [NativeTypeName("FT_Long")]
    public nint glyph_size;

    [NativeTypeName("FT_Glyph_Format")]
    public SharpFont.GlyphFormat glyph_format;

    [NativeTypeName("FT_Glyph_InitFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec_*, FT_GlyphSlotRec_*, SharpFont.Error> glyph_init;

    [NativeTypeName("FT_Glyph_DoneFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec_*, void> glyph_done;

    [NativeTypeName("FT_Glyph_CopyFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec_*, FT_GlyphRec_*, SharpFont.Error> glyph_copy;

    [NativeTypeName("FT_Glyph_TransformFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec_*, SharpFont.FTMatrix*, SharpFont.FTVector*, void> glyph_transform;

    [NativeTypeName("FT_Glyph_GetBBoxFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec_*, SharpFont.BBox*, void> glyph_bbox;

    [NativeTypeName("FT_Glyph_PrepareFunc")]
    public delegate* unmanaged[Cdecl]<FT_GlyphRec_*, FT_GlyphSlotRec_*, SharpFont.Error> glyph_prepare;
}
