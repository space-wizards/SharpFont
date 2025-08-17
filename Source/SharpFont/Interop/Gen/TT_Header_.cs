using System;
using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal partial struct TT_Header_
{
    [NativeTypeName("FT_Fixed")]
    public nint Table_Version;

    [NativeTypeName("FT_Fixed")]
    public nint Font_Revision;

    [NativeTypeName("FT_Long")]
    public nint CheckSum_Adjust;

    [NativeTypeName("FT_Long")]
    public nint Magic_Number;

    [NativeTypeName("FT_UShort")]
    public ushort Flags;

    [NativeTypeName("FT_UShort")]
    public ushort Units_Per_EM;

    [NativeTypeName("FT_ULong[2]")]
    public _Created_e__FixedBuffer Created;

    [NativeTypeName("FT_ULong[2]")]
    public _Modified_e__FixedBuffer Modified;

    [NativeTypeName("FT_Short")]
    public short xMin;

    [NativeTypeName("FT_Short")]
    public short yMin;

    [NativeTypeName("FT_Short")]
    public short xMax;

    [NativeTypeName("FT_Short")]
    public short yMax;

    [NativeTypeName("FT_UShort")]
    public ushort Mac_Style;

    [NativeTypeName("FT_UShort")]
    public ushort Lowest_Rec_PPEM;

    [NativeTypeName("FT_Short")]
    public short Font_Direction;

    [NativeTypeName("FT_Short")]
    public short Index_To_Loc_Format;

    [NativeTypeName("FT_Short")]
    public short Glyph_Data_Format;

    public partial struct _Created_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;

        public ref nuint this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }

    public partial struct _Modified_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;

        public ref nuint this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
