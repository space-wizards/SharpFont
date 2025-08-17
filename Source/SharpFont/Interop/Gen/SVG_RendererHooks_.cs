namespace SharpFont.Interop;

internal unsafe partial struct SVG_RendererHooks_
{
    [NativeTypeName("SVG_Lib_Init_Func")]
    public delegate* unmanaged[Cdecl]<void**, SharpFont.Error> init_svg;

    [NativeTypeName("SVG_Lib_Free_Func")]
    public delegate* unmanaged[Cdecl]<void**, void> free_svg;

    [NativeTypeName("SVG_Lib_Render_Func")]
    public delegate* unmanaged[Cdecl]<FT_GlyphSlotRec_*, void**, SharpFont.Error> render_svg;

    [NativeTypeName("SVG_Lib_Preset_Slot_Func")]
    public delegate* unmanaged[Cdecl]<FT_GlyphSlotRec_*, byte, void**, SharpFont.Error> preset_slot;
}
