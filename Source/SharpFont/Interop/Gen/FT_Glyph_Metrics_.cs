namespace SharpFont.Interop;

internal partial struct FT_Glyph_Metrics_
{
    [NativeTypeName("FT_Pos")]
    public nint width;

    [NativeTypeName("FT_Pos")]
    public nint height;

    [NativeTypeName("FT_Pos")]
    public nint horiBearingX;

    [NativeTypeName("FT_Pos")]
    public nint horiBearingY;

    [NativeTypeName("FT_Pos")]
    public nint horiAdvance;

    [NativeTypeName("FT_Pos")]
    public nint vertBearingX;

    [NativeTypeName("FT_Pos")]
    public nint vertBearingY;

    [NativeTypeName("FT_Pos")]
    public nint vertAdvance;
}
