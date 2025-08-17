namespace SharpFont.Interop;

internal unsafe partial struct PS_FontInfoRec_
{
    [NativeTypeName("FT_String *")]
    public sbyte* version;

    [NativeTypeName("FT_String *")]
    public sbyte* notice;

    [NativeTypeName("FT_String *")]
    public sbyte* full_name;

    [NativeTypeName("FT_String *")]
    public sbyte* family_name;

    [NativeTypeName("FT_String *")]
    public sbyte* weight;

    [NativeTypeName("FT_Long")]
    public nint italic_angle;

    [NativeTypeName("FT_Bool")]
    public byte is_fixed_pitch;

    [NativeTypeName("FT_Short")]
    public short underline_position;

    [NativeTypeName("FT_UShort")]
    public ushort underline_thickness;
}
