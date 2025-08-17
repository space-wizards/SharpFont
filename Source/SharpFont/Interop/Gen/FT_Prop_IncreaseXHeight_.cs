namespace SharpFont.Interop;

internal unsafe partial struct FT_Prop_IncreaseXHeight_
{
    [NativeTypeName("FT_Face")]
    public FT_FaceRec_* face;

    [NativeTypeName("FT_UInt")]
    public uint limit;
}
