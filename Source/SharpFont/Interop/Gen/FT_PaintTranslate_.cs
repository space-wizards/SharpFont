namespace SharpFont.Interop;

internal partial struct FT_PaintTranslate_
{
    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ paint;

    [NativeTypeName("FT_Fixed")]
    public nint dx;

    [NativeTypeName("FT_Fixed")]
    public nint dy;
}
