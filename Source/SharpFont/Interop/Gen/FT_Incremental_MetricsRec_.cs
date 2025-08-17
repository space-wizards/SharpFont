namespace SharpFont.Interop;

internal partial struct FT_Incremental_MetricsRec_
{
    [NativeTypeName("FT_Long")]
    public nint bearing_x;

    [NativeTypeName("FT_Long")]
    public nint bearing_y;

    [NativeTypeName("FT_Long")]
    public nint advance;

    [NativeTypeName("FT_Long")]
    public nint advance_v;
}
