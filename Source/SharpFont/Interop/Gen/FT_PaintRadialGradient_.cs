namespace SharpFont.Interop;

internal partial struct FT_PaintRadialGradient_
{
    [NativeTypeName("FT_ColorLine")]
    public FT_ColorLine_ colorline;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector c0;

    [NativeTypeName("FT_Pos")]
    public nint r0;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector c1;

    [NativeTypeName("FT_Pos")]
    public nint r1;
}
