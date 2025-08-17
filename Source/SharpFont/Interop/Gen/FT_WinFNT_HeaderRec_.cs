using System;
using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal unsafe partial struct FT_WinFNT_HeaderRec_
{
    [NativeTypeName("FT_UShort")]
    public ushort version;

    [NativeTypeName("FT_ULong")]
    public nuint file_size;

    [NativeTypeName("FT_Byte[60]")]
    public fixed byte copyright[60];

    [NativeTypeName("FT_UShort")]
    public ushort file_type;

    [NativeTypeName("FT_UShort")]
    public ushort nominal_point_size;

    [NativeTypeName("FT_UShort")]
    public ushort vertical_resolution;

    [NativeTypeName("FT_UShort")]
    public ushort horizontal_resolution;

    [NativeTypeName("FT_UShort")]
    public ushort ascent;

    [NativeTypeName("FT_UShort")]
    public ushort internal_leading;

    [NativeTypeName("FT_UShort")]
    public ushort external_leading;

    [NativeTypeName("FT_Byte")]
    public byte italic;

    [NativeTypeName("FT_Byte")]
    public byte underline;

    [NativeTypeName("FT_Byte")]
    public byte strike_out;

    [NativeTypeName("FT_UShort")]
    public ushort weight;

    [NativeTypeName("FT_Byte")]
    public byte charset;

    [NativeTypeName("FT_UShort")]
    public ushort pixel_width;

    [NativeTypeName("FT_UShort")]
    public ushort pixel_height;

    [NativeTypeName("FT_Byte")]
    public byte pitch_and_family;

    [NativeTypeName("FT_UShort")]
    public ushort avg_width;

    [NativeTypeName("FT_UShort")]
    public ushort max_width;

    [NativeTypeName("FT_Byte")]
    public byte first_char;

    [NativeTypeName("FT_Byte")]
    public byte last_char;

    [NativeTypeName("FT_Byte")]
    public byte default_char;

    [NativeTypeName("FT_Byte")]
    public byte break_char;

    [NativeTypeName("FT_UShort")]
    public ushort bytes_per_row;

    [NativeTypeName("FT_ULong")]
    public nuint device_offset;

    [NativeTypeName("FT_ULong")]
    public nuint face_name_offset;

    [NativeTypeName("FT_ULong")]
    public nuint bits_pointer;

    [NativeTypeName("FT_ULong")]
    public nuint bits_offset;

    [NativeTypeName("FT_Byte")]
    public byte reserved;

    [NativeTypeName("FT_ULong")]
    public nuint flags;

    [NativeTypeName("FT_UShort")]
    public ushort A_space;

    [NativeTypeName("FT_UShort")]
    public ushort B_space;

    [NativeTypeName("FT_UShort")]
    public ushort C_space;

    [NativeTypeName("FT_UShort")]
    public ushort color_table_offset;

    [NativeTypeName("FT_ULong[4]")]
    public _reserved1_e__FixedBuffer reserved1;

    public partial struct _reserved1_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;
        public nuint e2;
        public nuint e3;

        public ref nuint this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
    }
}
