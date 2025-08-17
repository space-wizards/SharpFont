using System;
using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal partial class Methods
{
	static Methods()
	{
		// Library names should be fine on Windows, so no need to set import resolver.
		if (OperatingSystem.IsWindows())
			return;

		NativeLibrary.SetDllImportResolver(typeof(FT).Assembly, (name, assembly, path) =>
		{
			if (name != FT.FreetypeDll)
			{
				return IntPtr.Zero;
			}

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
			{
				return NativeLibrary.Load("libfreetype.so.6", typeof(FT).Assembly, path);
			}

			if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
				return NativeLibrary.Load("libfreetype.6.dylib", typeof(FT).Assembly, path);
			}

			return IntPtr.Zero;
		});
	}
}
