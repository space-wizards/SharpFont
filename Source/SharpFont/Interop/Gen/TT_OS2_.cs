namespace SharpFont.Interop;

internal unsafe partial struct TT_OS2_
{
    [NativeTypeName("FT_UShort")]
    public ushort version;

    [NativeTypeName("FT_Short")]
    public short xAvgCharWidth;

    [NativeTypeName("FT_UShort")]
    public ushort usWeightClass;

    [NativeTypeName("FT_UShort")]
    public ushort usWidthClass;

    [NativeTypeName("FT_UShort")]
    public ushort fsType;

    [NativeTypeName("FT_Short")]
    public short ySubscriptXSize;

    [NativeTypeName("FT_Short")]
    public short ySubscriptYSize;

    [NativeTypeName("FT_Short")]
    public short ySubscriptXOffset;

    [NativeTypeName("FT_Short")]
    public short ySubscriptYOffset;

    [NativeTypeName("FT_Short")]
    public short ySuperscriptXSize;

    [NativeTypeName("FT_Short")]
    public short ySuperscriptYSize;

    [NativeTypeName("FT_Short")]
    public short ySuperscriptXOffset;

    [NativeTypeName("FT_Short")]
    public short ySuperscriptYOffset;

    [NativeTypeName("FT_Short")]
    public short yStrikeoutSize;

    [NativeTypeName("FT_Short")]
    public short yStrikeoutPosition;

    [NativeTypeName("FT_Short")]
    public short sFamilyClass;

    [NativeTypeName("FT_Byte[10]")]
    public fixed byte panose[10];

    [NativeTypeName("FT_ULong")]
    public nuint ulUnicodeRange1;

    [NativeTypeName("FT_ULong")]
    public nuint ulUnicodeRange2;

    [NativeTypeName("FT_ULong")]
    public nuint ulUnicodeRange3;

    [NativeTypeName("FT_ULong")]
    public nuint ulUnicodeRange4;

    [NativeTypeName("FT_Char[4]")]
    public fixed sbyte achVendID[4];

    [NativeTypeName("FT_UShort")]
    public ushort fsSelection;

    [NativeTypeName("FT_UShort")]
    public ushort usFirstCharIndex;

    [NativeTypeName("FT_UShort")]
    public ushort usLastCharIndex;

    [NativeTypeName("FT_Short")]
    public short sTypoAscender;

    [NativeTypeName("FT_Short")]
    public short sTypoDescender;

    [NativeTypeName("FT_Short")]
    public short sTypoLineGap;

    [NativeTypeName("FT_UShort")]
    public ushort usWinAscent;

    [NativeTypeName("FT_UShort")]
    public ushort usWinDescent;

    [NativeTypeName("FT_ULong")]
    public nuint ulCodePageRange1;

    [NativeTypeName("FT_ULong")]
    public nuint ulCodePageRange2;

    [NativeTypeName("FT_Short")]
    public short sxHeight;

    [NativeTypeName("FT_Short")]
    public short sCapHeight;

    [NativeTypeName("FT_UShort")]
    public ushort usDefaultChar;

    [NativeTypeName("FT_UShort")]
    public ushort usBreakChar;

    [NativeTypeName("FT_UShort")]
    public ushort usMaxContext;

    [NativeTypeName("FT_UShort")]
    public ushort usLowerOpticalPointSize;

    [NativeTypeName("FT_UShort")]
    public ushort usUpperOpticalPointSize;
}
