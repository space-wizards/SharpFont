namespace SharpFont.Interop;

internal partial struct FT_ColorLine_
{
    [NativeTypeName("FT_PaintExtend")]
    public FT_PaintExtend_ extend;

    [NativeTypeName("FT_ColorStopIterator")]
    public FT_ColorStopIterator_ color_stop_iterator;
}
