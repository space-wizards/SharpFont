namespace SharpFont.Interop;

internal unsafe partial struct FT_LayerIterator_
{
    [NativeTypeName("FT_UInt")]
    public uint num_layers;

    [NativeTypeName("FT_UInt")]
    public uint layer;

    [NativeTypeName("FT_Byte *")]
    public byte* p;
}
