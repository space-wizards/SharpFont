using System;
using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal unsafe partial struct CID_FaceInfoRec_
{
    [NativeTypeName("FT_String *")]
    public sbyte* cid_font_name;

    [NativeTypeName("FT_Fixed")]
    public nint cid_version;

    [NativeTypeName("FT_Int")]
    public int cid_font_type;

    [NativeTypeName("FT_String *")]
    public sbyte* registry;

    [NativeTypeName("FT_String *")]
    public sbyte* ordering;

    [NativeTypeName("FT_Int")]
    public int supplement;

    [NativeTypeName("PS_FontInfoRec")]
    public PS_FontInfoRec_ font_info;

    [NativeTypeName("FT_BBox")]
    public SharpFont.BBox font_bbox;

    [NativeTypeName("FT_ULong")]
    public nuint uid_base;

    [NativeTypeName("FT_Int")]
    public int num_xuid;

    [NativeTypeName("FT_ULong[16]")]
    public _xuid_e__FixedBuffer xuid;

    [NativeTypeName("FT_ULong")]
    public nuint cidmap_offset;

    [NativeTypeName("FT_UInt")]
    public uint fd_bytes;

    [NativeTypeName("FT_UInt")]
    public uint gd_bytes;

    [NativeTypeName("FT_ULong")]
    public nuint cid_count;

    [NativeTypeName("FT_UInt")]
    public uint num_dicts;

    [NativeTypeName("CID_FaceDict")]
    public CID_FaceDictRec_* font_dicts;

    [NativeTypeName("FT_ULong")]
    public nuint data_offset;

    public partial struct _xuid_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;
        public nuint e2;
        public nuint e3;
        public nuint e4;
        public nuint e5;
        public nuint e6;
        public nuint e7;
        public nuint e8;
        public nuint e9;
        public nuint e10;
        public nuint e11;
        public nuint e12;
        public nuint e13;
        public nuint e14;
        public nuint e15;

        public ref nuint this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
