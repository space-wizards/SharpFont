namespace SharpFont.Interop;

internal partial struct FT_PaintTransform_
{
    [NativeTypeName("FT_OpaquePaint")]
    public FT_Opaque_Paint_ paint;

    [NativeTypeName("FT_Affine23")]
    public FT_Affine_23_ affine;
}
