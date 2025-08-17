namespace SharpFont.Interop;

internal unsafe partial struct FT_MM_Var_
{
    [NativeTypeName("FT_UInt")]
    public uint num_axis;

    [NativeTypeName("FT_UInt")]
    public uint num_designs;

    [NativeTypeName("FT_UInt")]
    public uint num_namedstyles;

    [NativeTypeName("FT_Var_Axis *")]
    public FT_Var_Axis_* axis;

    [NativeTypeName("FT_Var_Named_Style *")]
    public FT_Var_Named_Style_* namedstyle;
}
