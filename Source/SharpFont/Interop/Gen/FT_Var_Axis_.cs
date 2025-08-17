namespace SharpFont.Interop;

internal unsafe partial struct FT_Var_Axis_
{
    [NativeTypeName("FT_String *")]
    public sbyte* name;

    [NativeTypeName("FT_Fixed")]
    public nint minimum;

    [NativeTypeName("FT_Fixed")]
    public nint def;

    [NativeTypeName("FT_Fixed")]
    public nint maximum;

    [NativeTypeName("FT_ULong")]
    public nuint tag;

    [NativeTypeName("FT_UInt")]
    public uint strid;
}
