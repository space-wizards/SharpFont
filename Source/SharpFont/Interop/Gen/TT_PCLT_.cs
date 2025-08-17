namespace SharpFont.Interop;

internal unsafe partial struct TT_PCLT_
{
    [NativeTypeName("FT_Fixed")]
    public nint Version;

    [NativeTypeName("FT_ULong")]
    public nuint FontNumber;

    [NativeTypeName("FT_UShort")]
    public ushort Pitch;

    [NativeTypeName("FT_UShort")]
    public ushort xHeight;

    [NativeTypeName("FT_UShort")]
    public ushort Style;

    [NativeTypeName("FT_UShort")]
    public ushort TypeFamily;

    [NativeTypeName("FT_UShort")]
    public ushort CapHeight;

    [NativeTypeName("FT_UShort")]
    public ushort SymbolSet;

    [NativeTypeName("FT_Char[16]")]
    public fixed sbyte TypeFace[16];

    [NativeTypeName("FT_Char[8]")]
    public fixed sbyte CharacterComplement[8];

    [NativeTypeName("FT_Char[6]")]
    public fixed sbyte FileName[6];

    [NativeTypeName("FT_Char")]
    public sbyte StrokeWeight;

    [NativeTypeName("FT_Char")]
    public sbyte WidthType;

    [NativeTypeName("FT_Byte")]
    public byte SerifStyle;

    [NativeTypeName("FT_Byte")]
    public byte Reserved;
}
