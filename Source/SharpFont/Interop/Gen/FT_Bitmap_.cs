namespace SharpFont.Interop;

internal unsafe partial struct FT_Bitmap_
{
    [NativeTypeName("unsigned int")]
    public uint rows;

    [NativeTypeName("unsigned int")]
    public uint width;

    public int pitch;

    [NativeTypeName("unsigned char *")]
    public byte* buffer;

    [NativeTypeName("unsigned short")]
    public ushort num_grays;

    [NativeTypeName("unsigned char")]
    public byte pixel_mode;

    [NativeTypeName("unsigned char")]
    public byte palette_mode;

    public void* palette;
}
