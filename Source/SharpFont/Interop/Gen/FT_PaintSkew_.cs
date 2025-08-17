namespace SharpFont.Interop;

internal partial struct FT_PaintSkew_
{
    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ paint;

    [NativeTypeName("FT_Fixed")]
    public nint x_skew_angle;

    [NativeTypeName("FT_Fixed")]
    public nint y_skew_angle;

    [NativeTypeName("FT_Fixed")]
    public nint center_x;

    [NativeTypeName("FT_Fixed")]
    public nint center_y;
}
