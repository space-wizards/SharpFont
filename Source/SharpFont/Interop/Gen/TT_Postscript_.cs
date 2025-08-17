namespace SharpFont.Interop;

internal partial struct TT_Postscript_
{
    [NativeTypeName("FT_Fixed")]
    public nint FormatType;

    [NativeTypeName("FT_Fixed")]
    public nint italicAngle;

    [NativeTypeName("FT_Short")]
    public short underlinePosition;

    [NativeTypeName("FT_Short")]
    public short underlineThickness;

    [NativeTypeName("FT_ULong")]
    public nuint isFixedPitch;

    [NativeTypeName("FT_ULong")]
    public nuint minMemType42;

    [NativeTypeName("FT_ULong")]
    public nuint maxMemType42;

    [NativeTypeName("FT_ULong")]
    public nuint minMemType1;

    [NativeTypeName("FT_ULong")]
    public nuint maxMemType1;
}
