namespace SharpFont.Interop;

internal partial struct FT_Size_Metrics_
{
    [NativeTypeName("FT_UShort")]
    public ushort x_ppem;

    [NativeTypeName("FT_UShort")]
    public ushort y_ppem;

    [NativeTypeName("FT_Fixed")]
    public nint x_scale;

    [NativeTypeName("FT_Fixed")]
    public nint y_scale;

    [NativeTypeName("FT_Pos")]
    public nint ascender;

    [NativeTypeName("FT_Pos")]
    public nint descender;

    [NativeTypeName("FT_Pos")]
    public nint height;

    [NativeTypeName("FT_Pos")]
    public nint max_advance;
}
