namespace SharpFont.Interop;

internal partial struct FT_PaintScale_
{
    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ paint;

    [NativeTypeName("FT_Fixed")]
    public nint scale_x;

    [NativeTypeName("FT_Fixed")]
    public nint scale_y;

    [NativeTypeName("FT_Fixed")]
    public nint center_x;

    [NativeTypeName("FT_Fixed")]
    public nint center_y;
}
