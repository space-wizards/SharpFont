namespace SharpFont.Interop;

internal partial struct FT_PaintSweepGradient_
{
    [NativeTypeName("FT_ColorLine")]
    public FT_ColorLine_ colorline;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector center;

    [NativeTypeName("FT_Fixed")]
    public nint start_angle;

    [NativeTypeName("FT_Fixed")]
    public nint end_angle;
}
