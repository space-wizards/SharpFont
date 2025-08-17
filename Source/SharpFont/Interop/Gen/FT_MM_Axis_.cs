namespace SharpFont.Interop;

internal unsafe partial struct FT_MM_Axis_
{
    [NativeTypeName("FT_String *")]
    public sbyte* name;

    [NativeTypeName("FT_Long")]
    public nint minimum;

    [NativeTypeName("FT_Long")]
    public nint maximum;
}
