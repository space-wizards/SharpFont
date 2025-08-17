namespace SharpFont.Interop;

internal unsafe partial struct TT_VertHeader_
{
    [NativeTypeName("FT_Fixed")]
    public nint Version;

    [NativeTypeName("FT_Short")]
    public short Ascender;

    [NativeTypeName("FT_Short")]
    public short Descender;

    [NativeTypeName("FT_Short")]
    public short Line_Gap;

    [NativeTypeName("FT_UShort")]
    public ushort advance_Height_Max;

    [NativeTypeName("FT_Short")]
    public short min_Top_Side_Bearing;

    [NativeTypeName("FT_Short")]
    public short min_Bottom_Side_Bearing;

    [NativeTypeName("FT_Short")]
    public short yMax_Extent;

    [NativeTypeName("FT_Short")]
    public short caret_Slope_Rise;

    [NativeTypeName("FT_Short")]
    public short caret_Slope_Run;

    [NativeTypeName("FT_Short")]
    public short caret_Offset;

    [NativeTypeName("FT_Short[4]")]
    public fixed short Reserved[4];

    [NativeTypeName("FT_Short")]
    public short metric_Data_Format;

    [NativeTypeName("FT_UShort")]
    public ushort number_Of_VMetrics;

    public void* long_metrics;

    public void* short_metrics;
}
