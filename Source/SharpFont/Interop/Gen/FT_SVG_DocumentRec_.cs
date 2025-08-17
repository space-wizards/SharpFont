namespace SharpFont.Interop;

internal unsafe partial struct FT_SVG_DocumentRec_
{
    [NativeTypeName("FT_Byte *")]
    public byte* svg_document;

    [NativeTypeName("FT_ULong")]
    public nuint svg_document_length;

    [NativeTypeName("FT_Size_Metrics")]
    public FT_Size_Metrics_ metrics;

    [NativeTypeName("FT_UShort")]
    public ushort units_per_EM;

    [NativeTypeName("FT_UShort")]
    public ushort start_glyph_id;

    [NativeTypeName("FT_UShort")]
    public ushort end_glyph_id;

    [NativeTypeName("FT_Matrix")]
    public SharpFont.FTMatrix transform;

    [NativeTypeName("FT_Vector")]
    public SharpFont.FTVector delta;
}
