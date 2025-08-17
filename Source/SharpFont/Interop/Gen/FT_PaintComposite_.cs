namespace SharpFont.Interop;

internal partial struct FT_PaintComposite_
{
    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ source_paint;

    [NativeTypeName("FT_Composite_Mode")]
    public FT_Composite_Mode_ composite_mode;

    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ backdrop_paint;
}
