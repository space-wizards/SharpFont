namespace SharpFont.Interop;

internal partial struct FT_PaintGlyph_
{
    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ paint;

    [NativeTypeName("FT_UInt")]
    public uint glyphID;
}
