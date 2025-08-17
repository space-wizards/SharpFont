#region MIT License
/*Copyright (c) 2012-2014 Robert Rouhani <robert.rouhani@gmail.com>

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
	/// <summary><para>
	/// A structure used to model a TrueType OS/2 table. This is the long table version. All fields comply to the
	/// TrueType specification.
	/// </para><para>
	/// Note that we now support old Mac fonts which do not include an OS/2 table. In this case, the ‘version’ field is
	/// always set to 0xFFFF.
	/// </para></summary>
	public unsafe class OS2
	{
		#region Fields

		private TT_OS2_* reference;

		#endregion

		#region Constructors

		internal OS2(TT_OS2_* reference)
		{
			this.reference = reference;
		}

		#endregion

		#region Properties

		/// <summary>
		/// The version of this table.
		/// </summary>
		[CLSCompliant(false)]
		public ushort Version
		{
			get
			{
				return reference->version;
			}
		}

		/// <summary>
		/// The average glyph width, computed by averaging ALL non-zero width glyphs in the font, in pels/em.
		/// </summary>
		public short AverageCharWidth
		{
			get
			{
				return reference->xAvgCharWidth;
			}
		}

		/// <summary>
		/// The visual weight of the font.
		/// </summary>
		[CLSCompliant(false)]
		public ushort WeightClass
		{
			get
			{
				return reference->usWeightClass;
			}
		}

		/// <summary>
		/// The relative change in width from the normal aspect ratio.
		/// </summary>
		[CLSCompliant(false)]
		public ushort WidthClass
		{
			get
			{
				return reference->usWidthClass;
			}
		}

		/// <summary>
		/// Font embedding and subsetting licensing rights as determined by the font author.
		/// </summary>
		[CLSCompliant(false)]
		public EmbeddingTypes EmbeddingType
		{
			get
			{
				return (EmbeddingTypes)reference->fsType;
			}
		}

		/// <summary>
		/// The font author's recommendation for sizing glyphs (em square) to create subscripts when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SubscriptSizeX
		{
			get
			{
				return reference->ySubscriptXSize;
			}
		}

		/// <summary>
		/// The font author's recommendation for sizing glyphs (em height) to create subscripts when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SubscriptSizeY
		{
			get
			{
				return reference->ySubscriptYSize;
			}
		}

		/// <summary>
		/// The font author's recommendation for vertically positioning subscripts that are created when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SubscriptOffsetX
		{
			get
			{
				return reference->ySubscriptXOffset;
			}
		}

		/// <summary>
		/// The font author's recommendation for horizontally positioning subscripts that are created when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SubscriptOffsetY
		{
			get
			{
				return reference->ySubscriptYOffset;
			}
		}

		/// <summary>
		/// The font author's recommendation for sizing glyphs (em square) to create superscripts when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SuperscriptSizeX
		{
			get
			{
				return reference->ySuperscriptXSize;
			}
		}

		/// <summary>
		/// The font author's recommendation for sizing glyphs (em height) to create superscripts when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SuperscriptSizeY
		{
			get
			{
				return reference->ySuperscriptYSize;
			}
		}

		/// <summary>
		/// The font author's recommendation for vertically positioning superscripts that are created when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SuperscriptOffsetX
		{
			get
			{
				return reference->ySuperscriptXOffset;
			}
		}

		/// <summary>
		/// The font author's recommendation for horizontally positioning superscripts that are created when a glyph doesn't exist for a subscript.
		/// </summary>
		public short SuperscriptOffsetY
		{
			get
			{
				return reference->ySuperscriptYOffset;
			}
		}

		/// <summary>
		/// The thickness of the strikeout stroke.
		/// </summary>
		public short StrikeoutSize
		{
			get
			{
				return reference->yStrikeoutSize;
			}
		}

		/// <summary>
		/// The position of the top of the strikeout line relative to the baseline.
		/// </summary>
		public short StrikeoutPosition
		{
			get
			{
				return reference->yStrikeoutPosition;
			}
		}

		/// <summary>
		/// The IBM font family class and subclass, useful for choosing visually similar fonts.
		/// </summary>
		/// <remarks>Refer to https://www.microsoft.com/typography/otspec160/ibmfc.htm. </remarks>
		public short FamilyClass
		{
			get
			{
				return reference->sFamilyClass;
			}
		}

		//TODO write a PANOSE class from TrueType spec?
		/// <summary>
		/// The Panose values describe visual characteristics of the font.
		/// Similar fonts can then be selected based on their Panose values.
		/// </summary>
		public byte[] Panose
		{
			get
			{
				return new ReadOnlySpan<byte>(reference->panose, 10).ToArray();
			}
		}

		/// <summary>
		/// Unicode character range, bits 0-31.
		/// </summary>
		[CLSCompliant(false)]
		public uint UnicodeRange1
		{
			get
			{
				return (uint)reference->ulUnicodeRange1;
			}
		}

		/// <summary>
		/// Unicode character range, bits 32-63.
		/// </summary>
		[CLSCompliant(false)]
		public uint UnicodeRange2
		{
			get
			{
				return (uint)reference->ulUnicodeRange2;
			}
		}

		/// <summary>
		/// Unicode character range, bits 64-95.
		/// </summary>
		[CLSCompliant(false)]
		public uint UnicodeRange3
		{
			get
			{
				return (uint)reference->ulUnicodeRange3;
			}
		}

		/// <summary>
		/// Unicode character range, bits 96-127.
		/// </summary>
		[CLSCompliant(false)]
		public uint UnicodeRange4
		{
			get
			{
				return (uint)reference->ulUnicodeRange4;
			}
		}

		/// <summary>
		/// The vendor's identifier.
		/// </summary>
		public byte[] VendorId
		{
			get
			{
				return new ReadOnlySpan<byte>(reference->achVendID, 4).ToArray();
			}
		}

		/// <summary>
		/// Describes variations in the font.
		/// </summary>
		[CLSCompliant(false)]
		public ushort SelectionFlags
		{
			get
			{
				return reference->fsSelection;
			}
		}

		/// <summary>
		/// The minimum Unicode index (character code) in this font.
		/// Since this value is limited to 0xFFFF, applications should not use this field.
		/// </summary>
		[CLSCompliant(false)]
		public ushort FirstCharIndex
		{
			get
			{
				return reference->usFirstCharIndex;
			}
		}

		/// <summary>
		/// The maximum Unicode index (character code) in this font.
		/// Since this value is limited to 0xFFFF, applications should not use this field.
		/// </summary>
		[CLSCompliant(false)]
		public ushort LastCharIndex
		{
			get
			{
				return reference->usLastCharIndex;
			}
		}

		/// <summary>
		/// The ascender value, useful for computing a default line spacing in conjunction with unitsPerEm.
		/// </summary>
		public short TypographicAscender
		{
			get
			{
				return reference->sTypoAscender;
			}
		}

		/// <summary>
		/// The descender value, useful for computing a default line spacing in conjunction with unitsPerEm.
		/// </summary>
		public short TypographicDescender
		{
			get
			{
				return reference->sTypoDescender;
			}
		}

		/// <summary>
		/// The line gap value, useful for computing a default line spacing in conjunction with unitsPerEm.
		/// </summary>
		public short TypographicLineGap
		{
			get
			{
				return reference->sTypoLineGap;
			}
		}

		/// <summary>
		/// The ascender metric for Windows, usually set to yMax. Windows will clip glyphs that go above this value.
		/// </summary>
		[CLSCompliant(false)]
		public ushort WindowsAscent
		{
			get
			{
				return reference->usWinAscent;
			}
		}

		/// <summary>
		/// The descender metric for Windows, usually set to yMin. Windows will clip glyphs that go below this value.
		/// </summary>
		[CLSCompliant(false)]
		public ushort WindowsDescent
		{
			get
			{
				return reference->usWinDescent;
			}
		}

		/// <summary>
		/// Specifies the code pages encompassed by this font.
		/// </summary>
		[CLSCompliant(false)]
		public uint CodePageRange1
		{
			get
			{
				return (uint)reference->ulCodePageRange1;
			}
		}

		/// <summary>
		/// Specifies the code pages encompassed by this font.
		/// </summary>
		[CLSCompliant(false)]
		public uint CodePageRange2
		{
			get
			{
				return (uint)reference->ulUnicodeRange1;
			}
		}

		/// <summary>
		/// The approximate height of non-ascending lowercase letters relative to the baseline.
		/// </summary>
		public short Height
		{
			get
			{
				return reference->sxHeight;
			}
		}

		/// <summary>
		/// The approximate height of uppercase letters relative to the baseline.
		/// </summary>
		public short CapHeight
		{
			get
			{
				return reference->sCapHeight;
			}
		}

		/// <summary>
		/// The Unicode index (character code)  of the glyph to use when a glyph doesn't exist for the requested character.
		/// Since this value is limited to 0xFFFF, applications should not use this field.
		/// </summary>
		[CLSCompliant(false)]
		public ushort DefaultChar
		{
			get
			{
				return reference->usDefaultChar;
			}
		}

		/// <summary>
		/// The Unicode index (character code)  of the glyph to use as the break character.
		/// The 'space' character is normally the break character.
		/// Since this value is limited to 0xFFFF, applications should not use this field.
		/// </summary>
		[CLSCompliant(false)]
		public ushort BreakChar
		{
			get
			{
				return reference->usBreakChar;
			}
		}

		/// <summary>
		/// The maximum number of characters needed to determine glyph context when applying features such as ligatures.
		/// </summary>
		[CLSCompliant(false)]
		public ushort MaxContext
		{
			get
			{
				return reference->usMaxContext;
			}
		}

		/// <summary>
		/// The lowest point size at which the font starts to be used, in twips.
		/// </summary>
		[CLSCompliant(false)]
		public ushort LowerOpticalPointSize
		{
			get
			{
				return reference->usLowerOpticalPointSize;
			}
		}

		/// <summary>
		/// The highest point size at which the font is no longer used, in twips.
		/// </summary>
		[CLSCompliant(false)]
		public ushort UpperOpticalPointSize
		{
			get
			{
				return reference->usUpperOpticalPointSize;
			}
		}

		#endregion
	}
}
