using System.Runtime.InteropServices;

namespace SharpFont.Interop;

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct FT_StreamDesc_
{
    [FieldOffset(0)]
    [NativeTypeName("long")]
    public int value;

    [FieldOffset(0)]
    public void* pointer;
}
