namespace SharpFont.Interop;

internal unsafe partial struct FT_Palette_Data_
{
    [NativeTypeName("FT_UShort")]
    public ushort num_palettes;

    [NativeTypeName("const FT_UShort *")]
    public ushort* palette_name_ids;

    [NativeTypeName("const FT_UShort *")]
    public ushort* palette_flags;

    [NativeTypeName("FT_UShort")]
    public ushort num_palette_entries;

    [NativeTypeName("const FT_UShort *")]
    public ushort* palette_entry_name_ids;
}
