namespace SharpFont.Interop;

internal unsafe partial struct FT_GlyphSlotRec_
{
    [NativeTypeName("FT_Library")]
    public FT_LibraryRec_* library;

    [NativeTypeName("FT_Face")]
    public FT_FaceRec_* face;

    [NativeTypeName("FT_GlyphSlot")]
    public FT_GlyphSlotRec_* next;

    [NativeTypeName("FT_UInt")]
    public uint glyph_index;

    [NativeTypeName("FT_Generic")]
    public FT_Generic_ generic;

    [NativeTypeName("FT_Glyph_Metrics")]
    public FT_Glyph_Metrics_ metrics;

    [NativeTypeName("FT_Fixed")]
    public nint linearHoriAdvance;

    [NativeTypeName("FT_Fixed")]
    public nint linearVertAdvance;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector advance;

    [NativeTypeName("FT_Glyph_Format")]
    public SharpFont.GlyphFormat format;

    [NativeTypeName("FT_Bitmap")]
    public FT_Bitmap_ bitmap;

    [NativeTypeName("FT_Int")]
    public int bitmap_left;

    [NativeTypeName("FT_Int")]
    public int bitmap_top;

    [NativeTypeName("FT_Outline")]
    public FT_Outline_ outline;

    [NativeTypeName("FT_UInt")]
    public uint num_subglyphs;

    [NativeTypeName("FT_SubGlyph")]
    public FT_SubGlyphRec_* subglyphs;

    public void* control_data;

    [NativeTypeName("long")]
    public int control_len;

    [NativeTypeName("FT_Pos")]
    public nint lsb_delta;

    [NativeTypeName("FT_Pos")]
    public nint rsb_delta;

    public void* other;

    [NativeTypeName("FT_Slot_Internal")]
    public FT_Slot_InternalRec_* @internal;
}
