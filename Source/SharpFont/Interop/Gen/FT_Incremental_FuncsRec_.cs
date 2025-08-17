namespace SharpFont.Interop;

internal unsafe partial struct FT_Incremental_FuncsRec_
{
    [NativeTypeName("FT_Incremental_GetGlyphDataFunc")]
    public delegate* unmanaged[Cdecl]<FT_IncrementalRec_*, uint, FT_Data_*, SharpFont.Error> get_glyph_data;

    [NativeTypeName("FT_Incremental_FreeGlyphDataFunc")]
    public delegate* unmanaged[Cdecl]<FT_IncrementalRec_*, FT_Data_*, void> free_glyph_data;

    [NativeTypeName("FT_Incremental_GetGlyphMetricsFunc")]
    public delegate* unmanaged[Cdecl]<FT_IncrementalRec_*, uint, byte, FT_Incremental_MetricsRec_*, SharpFont.Error> get_glyph_metrics;
}
