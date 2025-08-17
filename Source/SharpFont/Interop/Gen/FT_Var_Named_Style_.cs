namespace SharpFont.Interop;

internal unsafe partial struct FT_Var_Named_Style_
{
    [NativeTypeName("FT_Fixed *")]
    public nint* coords;

    [NativeTypeName("FT_UInt")]
    public uint strid;

    [NativeTypeName("FT_UInt")]
    public uint psid;
}
