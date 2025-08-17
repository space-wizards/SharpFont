using System;

namespace SharpFont;

public abstract class NativeObject
{
	internal abstract IntPtr UntypedReference { get; }
}
