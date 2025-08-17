namespace SharpFont.Interop;

internal partial struct FT_ClipBox_
{
    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector bottom_left;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector top_left;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector top_right;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector bottom_right;
}
