namespace SharpFont.Interop;

internal unsafe partial struct FT_Raster_Params_
{
    [NativeTypeName("const FT_Bitmap *")]
    public FT_Bitmap_* target;

    [NativeTypeName("const void *")]
    public void* source;

    public int flags;

    [NativeTypeName("FT_SpanFunc")]
    public delegate* unmanaged[Cdecl]<int, int, FT_Span_*, void*, void> gray_spans;

    [NativeTypeName("FT_SpanFunc")]
    public delegate* unmanaged[Cdecl]<int, int, FT_Span_*, void*, void> black_spans;

    [NativeTypeName("FT_Raster_BitTest_Func")]
    public delegate* unmanaged[Cdecl]<int, int, void*, int> bit_test;

    [NativeTypeName("FT_Raster_BitSet_Func")]
    public delegate* unmanaged[Cdecl]<int, int, void*, void> bit_set;

    public void* user;

    [NativeTypeName("FT_BBox")]
    public SharpFont.BBox clip_box;
}
