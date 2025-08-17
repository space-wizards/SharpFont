namespace SharpFont.Interop;

internal partial struct FT_ColorIndex_
{
    [NativeTypeName("FT_UInt16")]
    public ushort palette_index;

    [NativeTypeName("FT_F2Dot14")]
    public short alpha;
}
