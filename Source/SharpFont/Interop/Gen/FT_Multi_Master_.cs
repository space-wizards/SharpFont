using System;
using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal partial struct FT_Multi_Master_
{
    [NativeTypeName("FT_UInt")]
    public uint num_axis;

    [NativeTypeName("FT_UInt")]
    public uint num_designs;

    [NativeTypeName("FT_MM_Axis[4]")]
    public _axis_e__FixedBuffer axis;

    public partial struct _axis_e__FixedBuffer
    {
        public FT_MM_Axis_ e0;
        public FT_MM_Axis_ e1;
        public FT_MM_Axis_ e2;
        public FT_MM_Axis_ e3;

        public ref FT_MM_Axis_ this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<FT_MM_Axis_> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
    }
}
