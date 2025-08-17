namespace SharpFont.Interop;

internal unsafe partial struct FT_Open_Args_
{
    [NativeTypeName("FT_UInt")]
    public uint flags;

    [NativeTypeName("const FT_Byte *")]
    public byte* memory_base;

    [NativeTypeName("FT_Long")]
    public nint memory_size;

    [NativeTypeName("FT_String *")]
    public sbyte* pathname;

    [NativeTypeName("FT_Stream")]
    public FT_StreamRec_* stream;

    [NativeTypeName("FT_Module")]
    public FT_ModuleRec_* driver;

    [NativeTypeName("FT_Int")]
    public int num_params;

    [NativeTypeName("FT_Parameter *")]
    public FT_Parameter_* @params;
}
