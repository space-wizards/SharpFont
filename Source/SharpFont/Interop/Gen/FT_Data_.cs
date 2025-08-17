namespace SharpFont.Interop;

internal unsafe partial struct FT_Data_
{
    [NativeTypeName("const FT_Byte *")]
    public byte* pointer;

    [NativeTypeName("FT_UInt")]
    public uint length;
}
