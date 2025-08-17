#region MIT License
/*Copyright (c) 2012-2013, 2016 Robert Rouhani <robert.rouhani@gmail.com>

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
using System.Runtime.InteropServices;
using SharpFont.Interop;

namespace SharpFont.PostScript
{
	/// <summary>
	/// A structure used to represent CID Face information.
	/// </summary>
	public unsafe class FaceInfo
	{
		#region Fields

		private CID_FaceInfoRec_* reference;

		#endregion

		#region Constructors

		internal FaceInfo(CID_FaceInfoRec_* reference)
		{
			this.reference = reference;
		}

		#endregion

		#region Properties

		/// <summary>
		/// The name of the font, usually condensed from FullName.
		/// </summary>
		public string CidFontName
		{
			get
			{
				return Marshal.PtrToStringAnsi((IntPtr)reference->cid_font_name);
			}
		}

		/// <summary>
		/// The version number of the font.
		/// </summary>
		public int CidVersion
		{
			get
			{
				return (int)reference->cid_version;
			}
		}

		/// <summary>
		/// Gets the string identifying the font's manufacturer.
		/// </summary>
		public string Registry
		{
			get
			{
				return Marshal.PtrToStringAnsi((IntPtr)reference->registry);
			}
		}

		/// <summary>
		/// Gets the unique identifier for the character collection.
		/// </summary>
		public string Ordering
		{
			get
			{
				return Marshal.PtrToStringAnsi((IntPtr)reference->ordering);
			}
		}

		/// <summary>
		/// Gets the identifier (supplement number) of the character collection.
		/// </summary>
		public int Supplement
		{
			get
			{
				return reference->supplement;
			}
		}

		/// <summary>
		/// Gets the dictionary of font info that is not used by the PostScript interpreter.
		/// </summary>
		public FontInfo FontInfo
		{
			get
			{
				return new FontInfo(reference->font_info);
			}
		}

		/// <summary>
		/// Gets the coordinates of the corners of the bounding box.
		/// </summary>
		public BBox FontBBox
		{
			get
			{
				return reference->font_bbox;
			}
		}

		/// <summary>
		/// Gets the value to form UniqueID entries for base fonts within a composite font.
		/// </summary>
		[CLSCompliant(false)]
		public uint UidBase
		{
			get
			{
				return (uint)reference->uid_base;
			}
		}

		/// <summary>
		/// Gets the number of entries in the XUID array.
		/// </summary>
		public int XuidCount
		{
			get
			{
				return reference->num_xuid;
			}
		}

		/// <summary>
		/// Gets the extended unique IDS that identify the form, which allows
		/// the PostScript interpreter to cache the output for reuse.
		/// </summary>
		[CLSCompliant(false)]
		public uint[] Xuid
		{
			get
			{
				var srcXuids = reference->xuid.AsSpan();
				uint[] xuid = new uint[srcXuids.Length];
				for (int i = 0; i < xuid.Length; i++)
					xuid[i] = (uint)srcXuids[i];

				return xuid;
			}
		}

		/// <summary>
		/// Gets the offset in bytes to the charstring offset table.
		/// </summary>
		[CLSCompliant(false)]
		public uint CidMapOffset
		{
			get
			{
				return (uint)reference->cidmap_offset;
			}
		}

		/// <summary>
		/// Gets the length in bytes of the FDArray index.
		/// A value of 0 indicates that the charstring offset table doesn't contain
		/// any FDArray indexes.
		/// </summary>
		public int FDBytes
		{
			get
			{
				return (int)reference->fd_bytes;
			}
		}

		/// <summary>
		/// Gets the length of the offset to the charstring for each CID in the CID font.
		/// </summary>
		public int GDBytes
		{
			get
			{
				return (int)reference->gd_bytes;
			}
		}

		/// <summary>
		/// Gets the number of valid CIDs in the CIDFont.
		/// </summary>
		[CLSCompliant(false)]
		public uint CidCount
		{
			get
			{
				return (uint)reference->cid_count;
			}
		}

		/// <summary>
		/// Gets the number of entries in the FontDicts array.
		/// </summary>
		public int DictsCount
		{
			get
			{
				return (int)reference->num_dicts;
			}
		}

		/// <summary>
		/// Gets the set of font dictionaries for this font.
		/// </summary>
		public FaceDict[] FontDicts
		{
			get
			{
				var dicts = new FaceDict[DictsCount];
				for (var i = 0; i < dicts.Length; i++)
				{
					dicts[i] = new FaceDict(&reference->font_dicts[i]);
				}

				return dicts;
			}
		}

		/// <summary>
		/// The offset of the data.
		/// </summary>
		[CLSCompliant(false)]
		public uint DataOffset
		{
			get
			{
				return (uint)reference->data_offset;
			}
		}

		#endregion
	}
}
