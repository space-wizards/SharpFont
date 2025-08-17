#region MIT License
/*Copyright (c) 2012-2013, 2015-2016 Robert Rouhani <robert.rouhani@gmail.com>

SharpFont based on Tao.FreeType, Copyright (c) 2003-2007 Tao Framework Team

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#endregion

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpFont.Interop;

namespace SharpFont
{
	/// <summary>
	/// A structure used to describe a bitmap or pixmap to the raster. Note that we now manage pixmaps of various
	/// depths through the <see cref="PixelMode"/> field.
	/// </summary>
	/// <remarks>
	/// For now, the only pixel modes supported by FreeType are mono and grays. However, drivers might be added in the
	/// future to support more ‘colorful’ options.
	/// </remarks>
	public sealed unsafe class FTBitmap : IDisposable
	{
		#region Fields

		internal FT_Bitmap_* reference;

		private Library library;

		private bool disposed;

		//If the bitmap was generated with FT_Bitmap_New.
		private bool user;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FTBitmap"/> class.
		/// </summary>
		/// <param name="library">The parent <see cref="Library"/>.</param>
		public FTBitmap(Library library)
		{
			reference = (FT_Bitmap_*)NativeMemory.Alloc((nuint)Unsafe.SizeOf<FT_Bitmap_>());
			Methods.FT_Bitmap_New(reference);

			this.library = library;
			user = true;
		}

		internal FTBitmap(FT_Bitmap_* reference, Library library)
		{
			this.reference = reference;
			this.library = library;
		}

		/// <summary>
		/// Finalizes an instance of the <see cref="FTBitmap"/> class.
		/// </summary>
		~FTBitmap()
		{
			Dispose(false);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets a value indicating whether the <see cref="FTBitmap"/> has been disposed.
		/// </summary>
		public bool IsDisposed
		{
			get
			{
				return disposed;
			}
		}

		/// <summary>
		/// Gets the number of bitmap rows.
		/// </summary>
		public int Rows
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return (int)reference->rows;
			}
		}

		/// <summary>
		/// Gets the number of pixels in bitmap row.
		/// </summary>
		public int Width
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return (int)reference->width;
			}
		}

		/// <summary><para>
		/// Gets the pitch's absolute value is the number of bytes taken by one bitmap row, including padding. However,
		/// the pitch is positive when the bitmap has a ‘down’ flow, and negative when it has an ‘up’ flow. In all
		/// cases, the pitch is an offset to add to a bitmap pointer in order to go down one row.
		/// </para><para>
		/// Note that ‘padding’ means the alignment of a bitmap to a byte border, and FreeType functions normally align
		/// to the smallest possible integer value.
		/// </para><para>
		/// For the B/W rasterizer, ‘pitch’ is always an even number.
		/// </para><para>
		/// To change the pitch of a bitmap (say, to make it a multiple of 4), use <see cref="FTBitmap.Convert"/>.
		/// Alternatively, you might use callback functions to directly render to the application's surface; see the
		/// file ‘example2.cpp’ in the tutorial for a demonstration.
		/// </para></summary>
		public int Pitch
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return reference->pitch;
			}
		}

		/// <summary>
		/// Gets a typeless pointer to the bitmap buffer. This value should be aligned on 32-bit boundaries in most
		/// cases.
		/// </summary>
		public IntPtr Buffer
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return (IntPtr)reference->buffer;
			}
		}

		/// <summary>
		/// Gets the number of gray levels used in the bitmap. This field is only used with
		/// <see cref="SharpFont.PixelMode.Gray"/>.
		/// </summary>
		public short GrayLevels
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return (short)reference->num_grays;
			}
		}

		/// <summary>
		/// Gets the pixel mode, i.e., how pixel bits are stored.
		/// </summary>
		public PixelMode PixelMode
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return (PixelMode)reference->pixel_mode;
			}
		}

		/// <summary>
		/// Gets how the palette is stored. This field is intended for paletted pixel modes.
		/// </summary>
		[Obsolete("Not used currently.")]
		public byte PaletteMode
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return reference->palette_mode;
			}
		}

		/// <summary>
		/// Gets a typeless pointer to the bitmap palette; this field is intended for paletted pixel modes.
		/// </summary>
		[Obsolete("Not used currently.")]
		public IntPtr Palette
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				return (IntPtr)reference->palette;
			}
		}

		/// <summary>
		/// Gets the <see cref="FTBitmap"/>'s buffer as a byte array.
		/// </summary>
		public byte[] BufferData
		{
			get
			{
				if (disposed)
					throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

				//TODO deal with negative pitch
				byte[] data = new byte[reference->rows * reference->pitch];
				Marshal.Copy((nint)reference->buffer, data, 0, data.Length);
				return data;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Copy a bitmap into another one.
		/// </summary>
		/// <param name="library">A handle to a library object.</param>
		/// <returns>A handle to the target bitmap.</returns>
		public FTBitmap Copy(Library library)
		{
			if (disposed)
				throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

			if (library == null)
				throw new ArgumentNullException("library");

			FTBitmap newBitmap = new FTBitmap(library);
			Error err = Methods.FT_Bitmap_Copy(library.reference, reference, newBitmap.reference);

			if (err != Error.Ok)
				throw new FreeTypeException(err);

			return newBitmap;
		}

		/// <summary>
		/// Embolden a bitmap. The new bitmap will be about ‘xStrength’ pixels wider and ‘yStrength’ pixels higher. The
		/// left and bottom borders are kept unchanged.
		/// </summary>
		/// <remarks><para>
		/// The current implementation restricts ‘xStrength’ to be less than or equal to 8 if bitmap is of pixel_mode
		/// <see cref="SharpFont.PixelMode.Mono"/>.
		/// </para><para>
		/// If you want to embolden the bitmap owned by a <see cref="GlyphSlot"/>, you should call
		/// <see cref="GlyphSlot.OwnBitmap"/> on the slot first.
		/// </para></remarks>
		/// <param name="library">A handle to a library object.</param>
		/// <param name="xStrength">
		/// How strong the glyph is emboldened horizontally. Expressed in 26.6 pixel format.
		/// </param>
		/// <param name="yStrength">
		/// How strong the glyph is emboldened vertically. Expressed in 26.6 pixel format.
		/// </param>
		public void Embolden(Library library, Fixed26Dot6 xStrength, Fixed26Dot6 yStrength)
		{
			if (disposed)
				throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

			if (library == null)
				throw new ArgumentNullException("library");

			Error err = Methods.FT_Bitmap_Embolden(library.reference, reference, (IntPtr)xStrength.Value, (IntPtr)yStrength.Value);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Convert a bitmap object with depth 1bpp, 2bpp, 4bpp, or 8bpp to a bitmap object with depth 8bpp, making the
		/// number of used bytes per line (a.k.a. the ‘pitch’) a multiple of ‘alignment’.
		/// </summary>
		/// <remarks><para>
		/// It is possible to call <see cref="Convert"/> multiple times without calling
		/// <see cref="Dispose()"/> (the memory is simply reallocated).
		/// </para><para>
		/// Use <see cref="Dispose()"/> to finally remove the bitmap object.
		/// </para><para>
		/// The ‘library’ argument is taken to have access to FreeType's memory handling functions.
		/// </para></remarks>
		/// <param name="library">A handle to a library object.</param>
		/// <param name="alignment">
		/// The pitch of the bitmap is a multiple of this parameter. Common values are 1, 2, or 4.
		/// </param>
		/// <returns>The target bitmap.</returns>
		public FTBitmap Convert(Library library, int alignment)
		{
			if (disposed)
				throw new ObjectDisposedException("FTBitmap", "Cannot access a disposed object.");

			if (library == null)
				throw new ArgumentNullException("library");

			FTBitmap newBitmap = new FTBitmap(library);
			Error err = Methods.FT_Bitmap_Convert(library.reference, reference, newBitmap.reference, alignment);

			if (err != Error.Ok)
				throw new FreeTypeException(err);

			return newBitmap;
		}

		#region IDisposable

		/// <summary>
		/// Disposes an instance of the <see cref="FTBitmap"/> class.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (!disposed)
			{
				disposed = true;

				if (user)
				{
					Methods.FT_Bitmap_Done(library.reference, reference);
					Marshal.FreeHGlobal((IntPtr)reference);
				}

				reference = null;
				library = null;
			}
		}

		#endregion

		#endregion
	}
}
