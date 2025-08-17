namespace SharpFont.Interop;

internal partial struct CID_FaceDictRec_
{
    [NativeTypeName("PS_PrivateRec")]
    public PS_PrivateRec_ private_dict;

    [NativeTypeName("FT_UInt")]
    public uint len_buildchar;

    [NativeTypeName("FT_Fixed")]
    public nint forcebold_threshold;

    [NativeTypeName("FT_Pos")]
    public nint stroke_width;

    [NativeTypeName("FT_Fixed")]
    public nint expansion_factor;

    [NativeTypeName("FT_Byte")]
    public byte paint_type;

    [NativeTypeName("FT_Byte")]
    public byte font_type;

    [NativeTypeName("FT_Matrix")]
    public SharpFont.FTMatrix font_matrix;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector font_offset;

    [NativeTypeName("FT_UInt")]
    public uint num_subrs;

    [NativeTypeName("FT_ULong")]
    public nuint subrmap_offset;

    [NativeTypeName("FT_UInt")]
    public uint sd_bytes;
}
