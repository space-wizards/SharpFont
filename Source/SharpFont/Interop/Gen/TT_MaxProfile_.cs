namespace SharpFont.Interop;

internal partial struct TT_MaxProfile_
{
    [NativeTypeName("FT_Fixed")]
    public nint version;

    [NativeTypeName("FT_UShort")]
    public ushort numGlyphs;

    [NativeTypeName("FT_UShort")]
    public ushort maxPoints;

    [NativeTypeName("FT_UShort")]
    public ushort maxContours;

    [NativeTypeName("FT_UShort")]
    public ushort maxCompositePoints;

    [NativeTypeName("FT_UShort")]
    public ushort maxCompositeContours;

    [NativeTypeName("FT_UShort")]
    public ushort maxZones;

    [NativeTypeName("FT_UShort")]
    public ushort maxTwilightPoints;

    [NativeTypeName("FT_UShort")]
    public ushort maxStorage;

    [NativeTypeName("FT_UShort")]
    public ushort maxFunctionDefs;

    [NativeTypeName("FT_UShort")]
    public ushort maxInstructionDefs;

    [NativeTypeName("FT_UShort")]
    public ushort maxStackElements;

    [NativeTypeName("FT_UShort")]
    public ushort maxSizeOfInstructions;

    [NativeTypeName("FT_UShort")]
    public ushort maxComponentElements;

    [NativeTypeName("FT_UShort")]
    public ushort maxComponentDepth;
}
