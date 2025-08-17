namespace SharpFont.Interop;

internal unsafe partial struct FT_SfntLangTag_
{
    [NativeTypeName("FT_Byte *")]
    public byte* @string;

    [NativeTypeName("FT_UInt")]
    public uint string_len;
}
