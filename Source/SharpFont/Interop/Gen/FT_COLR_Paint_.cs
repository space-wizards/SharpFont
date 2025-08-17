using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal partial struct FT_COLR_Paint_
{
    [NativeTypeName("FT_PaintFormat")]
    public FT_PaintFormat_ format;

    [NativeTypeName("__AnonymousRecord_ftcolor_L1313_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    internal partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("FT_PaintColrLayers")]
        public FT_PaintColrLayers_ colr_layers;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintGlyph")]
        public FT_PaintGlyph_ glyph;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintSolid")]
        public FT_PaintSolid_ solid;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintLinearGradient")]
        public FT_PaintLinearGradient_ linear_gradient;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintRadialGradient")]
        public FT_PaintRadialGradient_ radial_gradient;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintSweepGradient")]
        public FT_PaintSweepGradient_ sweep_gradient;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintTransform")]
        public FT_PaintTransform_ transform;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintTranslate")]
        public FT_PaintTranslate_ translate;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintScale")]
        public FT_PaintScale_ scale;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintRotate")]
        public FT_PaintRotate_ rotate;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintSkew")]
        public FT_PaintSkew_ skew;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintComposite")]
        public FT_PaintComposite_ composite;

        [FieldOffset(0)]
        [NativeTypeName("FT_PaintColrGlyph")]
        public FT_PaintColrGlyph_ colr_glyph;
    }
}
