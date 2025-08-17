namespace SharpFont.Interop;

internal unsafe partial struct FT_StreamRec_
{
    [NativeTypeName("unsigned char *")]
    public byte* @base;

    [NativeTypeName("unsigned long")]
    public uint size;

    [NativeTypeName("unsigned long")]
    public uint pos;

    [NativeTypeName("FT_StreamDesc")]
    public FT_StreamDesc_ descriptor;

    [NativeTypeName("FT_StreamDesc")]
    public FT_StreamDesc_ pathname;

    [NativeTypeName("FT_Stream_IoFunc")]
    public delegate* unmanaged[Cdecl]<FT_StreamRec_*, uint, byte*, uint, uint> read;

    [NativeTypeName("FT_Stream_CloseFunc")]
    public delegate* unmanaged[Cdecl]<FT_StreamRec_*, void> close;

    [NativeTypeName("FT_Memory")]
    public FT_MemoryRec_* memory;

    [NativeTypeName("unsigned char *")]
    public byte* cursor;

    [NativeTypeName("unsigned char *")]
    public byte* limit;
}
