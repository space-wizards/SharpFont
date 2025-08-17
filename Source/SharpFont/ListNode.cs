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
	/// A structure used to hold a single list element.
	/// </summary>
	public unsafe class ListNode: NativeObject
	{
		#region Fields

		internal FT_ListNodeRec_* reference;

		#endregion

		internal override IntPtr UntypedReference => (IntPtr)reference;

		#region Constructors

		internal ListNode(FT_ListNodeRec_* reference)
		{
			this.reference = reference;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the previous element in the list. NULL if first.
		/// </summary>
		public ListNode Previous
		{
			get
			{
				if (reference->prev == null)
					return null;

				return new ListNode(reference->prev);
			}
		}

		/// <summary>
		/// Gets the next element in the list. NULL if last.
		/// </summary>
		public ListNode Next
		{
			get
			{
				if (reference->next == null)
					return null;

				return new ListNode(reference->next);
			}
		}

		/// <summary>
		/// Gets a typeless pointer to the listed object.
		/// </summary>
		public IntPtr Data
		{
			get
			{
				return (IntPtr)reference->data;
			}
		}

		#endregion
	}
}
