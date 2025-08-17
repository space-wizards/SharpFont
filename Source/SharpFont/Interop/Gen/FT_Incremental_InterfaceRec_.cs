namespace SharpFont.Interop;

internal unsafe partial struct FT_Incremental_InterfaceRec_
{
    [NativeTypeName("const FT_Incremental_FuncsRec *")]
    public FT_Incremental_FuncsRec_* funcs;

    [NativeTypeName("FT_Incremental")]
    public FT_IncrementalRec_* @object;
}
