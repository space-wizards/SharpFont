namespace SharpFont.Interop;

internal unsafe partial struct FT_Raster_Funcs_
{
    [NativeTypeName("FT_Glyph_Format")]
    public SharpFont.GlyphFormat glyph_format;

    [NativeTypeName("FT_Raster_NewFunc")]
    public delegate* unmanaged[Cdecl]<void*, FT_RasterRec_**, int> raster_new;

    [NativeTypeName("FT_Raster_ResetFunc")]
    public delegate* unmanaged[Cdecl]<FT_RasterRec_*, byte*, uint, void> raster_reset;

    [NativeTypeName("FT_Raster_SetModeFunc")]
    public delegate* unmanaged[Cdecl]<FT_RasterRec_*, uint, void*, int> raster_set_mode;

    [NativeTypeName("FT_Raster_RenderFunc")]
    public delegate* unmanaged[Cdecl]<FT_RasterRec_*, FT_Raster_Params_*, int> raster_render;

    [NativeTypeName("FT_Raster_DoneFunc")]
    public delegate* unmanaged[Cdecl]<FT_RasterRec_*, void> raster_done;
}
