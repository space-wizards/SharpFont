namespace SharpFont.Interop;

internal unsafe partial struct FT_Outline_Funcs_
{
    [NativeTypeName("FT_Outline_MoveToFunc")]
    public delegate* unmanaged[Cdecl]<SharpFont.FTVector*, void*, int> move_to;

    [NativeTypeName("FT_Outline_LineToFunc")]
    public delegate* unmanaged[Cdecl]<SharpFont.FTVector*, void*, int> line_to;

    [NativeTypeName("FT_Outline_ConicToFunc")]
    public delegate* unmanaged[Cdecl]<SharpFont.FTVector*, SharpFont.FTVector*, void*, int> conic_to;

    [NativeTypeName("FT_Outline_CubicToFunc")]
    public delegate* unmanaged[Cdecl]<SharpFont.FTVector*, SharpFont.FTVector*, SharpFont.FTVector*, void*, int> cubic_to;

    public int shift;

    [NativeTypeName("FT_Pos")]
    public nint delta;
}
