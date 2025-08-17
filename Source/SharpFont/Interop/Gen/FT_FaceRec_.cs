namespace SharpFont.Interop;

internal unsafe partial struct FT_FaceRec_
{
    [NativeTypeName("FT_Long")]
    public nint num_faces;

    [NativeTypeName("FT_Long")]
    public nint face_index;

    [NativeTypeName("FT_Long")]
    public nint face_flags;

    [NativeTypeName("FT_Long")]
    public nint style_flags;

    [NativeTypeName("FT_Long")]
    public nint num_glyphs;

    [NativeTypeName("FT_String *")]
    public sbyte* family_name;

    [NativeTypeName("FT_String *")]
    public sbyte* style_name;

    [NativeTypeName("FT_Int")]
    public int num_fixed_sizes;

    [NativeTypeName("FT_Bitmap_Size *")]
    public FT_Bitmap_Size_* available_sizes;

    [NativeTypeName("FT_Int")]
    public int num_charmaps;

    [NativeTypeName("FT_CharMap *")]
    public FT_CharMapRec_** charmaps;

    [NativeTypeName("FT_Generic")]
    public FT_Generic_ generic;

    [NativeTypeName("FT_BBox")]
    public SharpFont.BBox bbox;

    [NativeTypeName("FT_UShort")]
    public ushort units_per_EM;

    [NativeTypeName("FT_Short")]
    public short ascender;

    [NativeTypeName("FT_Short")]
    public short descender;

    [NativeTypeName("FT_Short")]
    public short height;

    [NativeTypeName("FT_Short")]
    public short max_advance_width;

    [NativeTypeName("FT_Short")]
    public short max_advance_height;

    [NativeTypeName("FT_Short")]
    public short underline_position;

    [NativeTypeName("FT_Short")]
    public short underline_thickness;

    [NativeTypeName("FT_GlyphSlot")]
    public FT_GlyphSlotRec_* glyph;

    [NativeTypeName("FT_Size")]
    public FT_SizeRec_* size;

    [NativeTypeName("FT_CharMap")]
    public FT_CharMapRec_* charmap;

    [NativeTypeName("FT_Driver")]
    public FT_DriverRec_* driver;

    [NativeTypeName("FT_Memory")]
    public FT_MemoryRec_* memory;

    [NativeTypeName("FT_Stream")]
    public FT_StreamRec_* stream;

    [NativeTypeName("FT_ListRec")]
    public FT_ListRec_ sizes_list;

    [NativeTypeName("FT_Generic")]
    public FT_Generic_ autohint;

    public void* extensions;

    [NativeTypeName("FT_Face_Internal")]
    public FT_Face_InternalRec_* @internal;
}
