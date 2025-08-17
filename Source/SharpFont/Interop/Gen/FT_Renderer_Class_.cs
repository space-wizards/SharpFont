namespace SharpFont.Interop;

internal unsafe partial struct FT_Renderer_Class_
{
    [NativeTypeName("FT_Module_Class")]
    public FT_Module_Class_ root;

    [NativeTypeName("FT_Glyph_Format")]
    public SharpFont.GlyphFormat glyph_format;

    [NativeTypeName("FT_Renderer_RenderFunc")]
    public delegate* unmanaged[Cdecl]<FT_RendererRec_*, FT_GlyphSlotRec_*, SharpFont.RenderMode, SharpFont.FTVector*, SharpFont.Error> render_glyph;

    [NativeTypeName("FT_Renderer_TransformFunc")]
    public delegate* unmanaged[Cdecl]<FT_RendererRec_*, FT_GlyphSlotRec_*, SharpFont.FTMatrix*, SharpFont.FTVector*, SharpFont.Error> transform_glyph;

    [NativeTypeName("FT_Renderer_GetCBoxFunc")]
    public delegate* unmanaged[Cdecl]<FT_RendererRec_*, FT_GlyphSlotRec_*, SharpFont.BBox*, void> get_glyph_cbox;

    [NativeTypeName("FT_Renderer_SetModeFunc")]
    public delegate* unmanaged[Cdecl]<FT_RendererRec_*, nuint, void*, SharpFont.Error> set_mode;

    [NativeTypeName("const FT_Raster_Funcs *")]
    public FT_Raster_Funcs_* raster_class;
}
