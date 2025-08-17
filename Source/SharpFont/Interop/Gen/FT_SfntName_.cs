namespace SharpFont.Interop;

internal unsafe partial struct FT_SfntName_
{
    [NativeTypeName("FT_UShort")]
    public ushort platform_id;

    [NativeTypeName("FT_UShort")]
    public ushort encoding_id;

    [NativeTypeName("FT_UShort")]
    public ushort language_id;

    [NativeTypeName("FT_UShort")]
    public ushort name_id;

    [NativeTypeName("FT_Byte *")]
    public byte* @string;

    [NativeTypeName("FT_UInt")]
    public uint string_len;
}
