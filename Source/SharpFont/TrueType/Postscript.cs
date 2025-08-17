#region MIT License
/*Copyright (c) 2012-2013 Robert Rouhani <robert.rouhani@gmail.com>

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
using SharpFont.Interop;

namespace SharpFont.TrueType
{
	/// <summary>
	/// A structure used to model a TrueType PostScript table. All fields comply to the TrueType specification. This
	/// structure does not reference the PostScript glyph names, which can be nevertheless accessed with the ‘ttpost’
	/// module.
	/// </summary>
	public unsafe class Postscript
	{
		#region Fields

		private TT_Postscript_* reference;

		#endregion

		#region Constructors

		internal Postscript(TT_Postscript_* reference)
		{
			this.reference = reference;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the version of the table information.
		/// </summary>
		public int FormatType
		{
			get
			{
				return (int)reference->FormatType;
			}
		}

		/// <summary>
		/// Gets the angle of italics, in degrees, counter-clockwise from vertical.
		/// </summary>
		public int ItalicAngle
		{
			get
			{
				return (int)reference->italicAngle;
			}
		}

		/// <summary>
		/// Gets the recommended position of the underline.
		/// </summary>
		public short UnderlinePosition
		{
			get
			{
				return reference->underlinePosition;
			}
		}

		/// <summary>
		/// Gets the recommended thickness of the underline.
		/// </summary>
		public short UnderlineThickness
		{
			get
			{
				return reference->underlineThickness;
			}
		}

		/// <summary>
		///
		/// </summary>
		[CLSCompliant(false)]
		public uint IsFixedPitch
		{
			get
			{
				return (uint)reference->isFixedPitch;
			}
		}

		/// <summary>
		/// Gets the minimum amount of memory used by the font when an OpenType font is loaded.
		/// </summary>
		[CLSCompliant(false)]
		public uint MinimumMemoryType42
		{
			get
			{
				return (uint)reference->minMemType42;
			}
		}

		/// <summary>
		/// Gets the maximum amount of memory used by the font when an OpenType font is loaded.
		/// </summary>
		[CLSCompliant(false)]
		public uint MaximumMemoryType42
		{
			get
			{
				return (uint)reference->maxMemType42;
			}
		}

		/// <summary>
		/// Gets the minimum amount of memory used by the font when an OpenType font is loaded as
		/// a Type 1 font.
		/// </summary>
		[CLSCompliant(false)]
		public uint MinimumMemoryType1
		{
			get
			{
				return (uint)reference->minMemType1;
			}
		}

		/// <summary>
		/// Gets the maximum amount of memory used by the font when an OpenType font is loaded as
		/// a Type 1 font.
		/// </summary>
		[CLSCompliant(false)]
		public uint MaximumMemoryType1
		{
			get
			{
				return (uint)reference->maxMemType1;
			}
		}

		#endregion
	}
}
