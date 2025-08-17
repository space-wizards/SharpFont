namespace SharpFont.Interop;

internal partial struct FT_ColorStop_
{
    [NativeTypeName("FT_Fixed")]
    public nint stop_offset;

    [NativeTypeName("FT_ColorIndex")]
    public FT_ColorIndex_ color;
}
