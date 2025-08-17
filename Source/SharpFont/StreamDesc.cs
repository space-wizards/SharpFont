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

namespace SharpFont
{
	/// <summary>
	/// A union type used to store either a long or a pointer. This is used to store a file descriptor or a ‘FILE*’ in
	/// an input stream.
	/// </summary>
	public unsafe class StreamDesc
	{
		#region Fields

		private FT_StreamDesc_* reference;

		#endregion

		#region Constructors

		internal StreamDesc(FT_StreamDesc_* reference)
		{
			this.reference = reference;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the <see cref="StreamDesc"/> as a file descriptor.
		/// </summary>
		public int Value
		{
			get
			{
				return (int)reference->value;
			}
		}

		/// <summary>
		/// Gets the <see cref="StreamDesc"/> as an input stream (FILE*).
		/// </summary>
		public IntPtr Pointer
		{
			get
			{
				return (IntPtr)reference->pointer;
			}
		}

		#endregion
	}
}
