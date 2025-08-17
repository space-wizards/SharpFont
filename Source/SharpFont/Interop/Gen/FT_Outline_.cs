namespace SharpFont.Interop;

internal unsafe partial struct FT_Outline_
{
    [NativeTypeName("unsigned short")]
    public ushort n_contours;

    [NativeTypeName("unsigned short")]
    public ushort n_points;

    [NativeTypeName("FT_Vector *")]
    public SharpFont.FTVector* points;

    [NativeTypeName("unsigned char *")]
    public byte* tags;

    [NativeTypeName("unsigned short *")]
    public ushort* contours;

    public int flags;
}
