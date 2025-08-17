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
using System.Runtime.InteropServices;
using SharpFont.Interop;

namespace SharpFont.Bdf
{
	/// <summary>
	/// This structure models a given BDF/PCF property.
	/// </summary>
	public unsafe class Property
	{
		#region Fields

		private readonly BDF_PropertyRec_ rec;

		#endregion

		#region Constructors

		internal Property(BDF_PropertyRec_ rec)
		{
			this.rec = rec;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the property type.
		/// </summary>
		public PropertyType Type
		{
			get
			{
				return rec.type;
			}
		}

		/// <summary>
		/// Gets the atom string, if type is <see cref="PropertyType.Atom"/>.
		/// </summary>
		public string Atom
		{
			get
			{
				// only this property throws an exception because the pointer could be to unmanaged memory not owned by
				// the process.
				if (rec.type != PropertyType.Atom)
					throw new InvalidOperationException("The property type is not Atom.");

				return Marshal.PtrToStringAnsi((IntPtr)rec.u.atom);
			}
		}

		/// <summary>
		/// Gets a signed integer, if type is <see cref="PropertyType.Integer"/>.
		/// </summary>
		public int Integer
		{
			get
			{
				return rec.u.integer;
			}
		}

		/// <summary>
		/// Gets an unsigned integer, if type is <see cref="PropertyType.Cardinal"/>.
		/// </summary>
		[CLSCompliant(false)]
		public uint Cardinal
		{
			get
			{
				return rec.u.cardinal;
			}
		}

		#endregion
	}
}
