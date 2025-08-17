namespace SharpFont.Interop;

internal partial struct FT_Color_
{
    [NativeTypeName("FT_Byte")]
    public byte blue;

    [NativeTypeName("FT_Byte")]
    public byte green;

    [NativeTypeName("FT_Byte")]
    public byte red;

    [NativeTypeName("FT_Byte")]
    public byte alpha;
}
