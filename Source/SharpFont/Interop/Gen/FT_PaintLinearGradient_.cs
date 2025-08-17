namespace SharpFont.Interop;

internal partial struct FT_PaintLinearGradient_
{
    [NativeTypeName("FT_ColorLine")]
    public FT_ColorLine_ colorline;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector p0;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector p1;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector p2;
}
