# Release Notes

## Master

* Library has been significantly rewritten internally to use a new FFI layer. This should probably fix a bunch of bugs (many APIs were previously outright broken), and makes the library more maintainable towards the future.
* Added `RenderMode.Sdf`.

## Current (wizards-1.0.2)

* Use `libfreetype.so.6` on FreeBSD.
* General repo cleanup to use modern practices, update to .NET 7.

## wizards-1.0.1

* Stop using `/usr/X11/lib/libfreetype.6.dylib` on macOS.

## wizards-1.0.0

This is the first release. Changes over base `SharpFont`:

* .NET Core 3 support
