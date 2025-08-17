namespace SharpFont.Interop;

internal unsafe partial struct FT_ColorStopIterator_
{
    [NativeTypeName("FT_UInt")]
    public uint num_color_stops;

    [NativeTypeName("FT_UInt")]
    public uint current_color_stop;

    [NativeTypeName("FT_Byte *")]
    public byte* p;

    [NativeTypeName("FT_Bool")]
    public byte read_variable;
}
