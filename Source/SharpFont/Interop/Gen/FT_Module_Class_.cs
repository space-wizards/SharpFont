namespace SharpFont.Interop;

internal unsafe partial struct FT_Module_Class_
{
    [NativeTypeName("FT_ULong")]
    public nuint module_flags;

    [NativeTypeName("FT_Long")]
    public nint module_size;

    [NativeTypeName("const FT_String *")]
    public sbyte* module_name;

    [NativeTypeName("FT_Fixed")]
    public nint module_version;

    [NativeTypeName("FT_Fixed")]
    public nint module_requires;

    [NativeTypeName("const void *")]
    public void* module_interface;

    [NativeTypeName("FT_Module_Constructor")]
    public delegate* unmanaged[Cdecl]<FT_ModuleRec_*, SharpFont.Error> module_init;

    [NativeTypeName("FT_Module_Destructor")]
    public delegate* unmanaged[Cdecl]<FT_ModuleRec_*, void> module_done;

    [NativeTypeName("FT_Module_Requester")]
    public delegate* unmanaged[Cdecl]<FT_ModuleRec_*, sbyte*, void*> get_interface;
}
