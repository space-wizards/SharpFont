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
using SharpFont.Interop;

namespace SharpFont.Cache
{
	/// <summary>
	/// A structure used to describe a given character size in either pixels or points to the cache manager.
	/// </summary>
	/// <remarks>
	/// This type is mainly used to retrieve <see cref="FTSize"/> objects through the cache manager.
	/// </remarks>
	/// <see cref="Manager.LookupSize"/>
	public unsafe class Scaler
	{
		#region Fields

		internal readonly FTC_ScalerRec_* reference;

		#endregion

		#region Constructors

		internal Scaler(FTC_ScalerRec_* reference)
		{
			this.reference = reference;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the source face ID.
		/// </summary>
		public IntPtr FaceId
		{
			get
			{
				return (IntPtr)reference->face_id;
			}
		}

		/// <summary>
		/// Gets the character width.
		/// </summary>
		[CLSCompliant(false)]
		public uint Width
		{
			get
			{
				return reference->width;
			}
		}

		/// <summary>
		/// Gets the character height.
		/// </summary>
		[CLSCompliant(false)]
		public uint Height
		{
			get
			{
				return reference->height;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the ‘width’ and ‘height’ fields are interpreted as integer pixel character
		/// sizes. Otherwise, they are expressed as 1/64th of points.
		/// </summary>
		public bool Pixel
		{
			get
			{
				return reference->pixel == 1;
			}
		}

		/// <summary>
		/// Gets the horizontal resolution in dpi; only used when ‘pixel’ is value 0.
		/// </summary>
		[CLSCompliant(false)]
		public uint ResolutionX
		{
			get
			{
				return reference->x_res;
			}
		}

		/// <summary>
		/// Gets the vertical resolution in dpi; only used when ‘pixel’ is value 0.
		/// </summary>
		[CLSCompliant(false)]
		public uint ResolutionY
		{
			get
			{
				return reference->y_res;
			}
		}

		#endregion
	}
}
