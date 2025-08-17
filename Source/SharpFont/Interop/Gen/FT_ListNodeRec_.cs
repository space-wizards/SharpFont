namespace SharpFont.Interop;

internal unsafe partial struct FT_ListNodeRec_
{
    [NativeTypeName("FT_ListNode")]
    public FT_ListNodeRec_* prev;

    [NativeTypeName("FT_ListNode")]
    public FT_ListNodeRec_* next;

    public void* data;
}
