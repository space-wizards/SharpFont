using System.Runtime.InteropServices;

namespace SharpFont.Interop;

internal static unsafe partial class Methods
{
    internal const int FT_Mod_Err_Base = 0;
    internal const int FT_Mod_Err_Autofit = 0;
    internal const int FT_Mod_Err_BDF = 0;
    internal const int FT_Mod_Err_Bzip2 = 0;
    internal const int FT_Mod_Err_Cache = 0;
    internal const int FT_Mod_Err_CFF = 0;
    internal const int FT_Mod_Err_CID = 0;
    internal const int FT_Mod_Err_Gzip = 0;
    internal const int FT_Mod_Err_LZW = 0;
    internal const int FT_Mod_Err_OTvalid = 0;
    internal const int FT_Mod_Err_PCF = 0;
    internal const int FT_Mod_Err_PFR = 0;
    internal const int FT_Mod_Err_PSaux = 0;
    internal const int FT_Mod_Err_PShinter = 0;
    internal const int FT_Mod_Err_PSnames = 0;
    internal const int FT_Mod_Err_Raster = 0;
    internal const int FT_Mod_Err_SFNT = 0;
    internal const int FT_Mod_Err_Smooth = 0;
    internal const int FT_Mod_Err_TrueType = 0;
    internal const int FT_Mod_Err_Type1 = 0;
    internal const int FT_Mod_Err_Type42 = 0;
    internal const int FT_Mod_Err_Winfonts = 0;
    internal const int FT_Mod_Err_GXvalid = 0;
    internal const int FT_Mod_Err_Sdf = 0;
    internal const int FT_Mod_Err_Max = 1;

    internal const int FT_Err_Ok = 0x00;
    internal const int FT_Err_Cannot_Open_Resource = 0x01 + 0;
    internal const int FT_Err_Unknown_File_Format = 0x02 + 0;
    internal const int FT_Err_Invalid_File_Format = 0x03 + 0;
    internal const int FT_Err_Invalid_Version = 0x04 + 0;
    internal const int FT_Err_Lower_Module_Version = 0x05 + 0;
    internal const int FT_Err_Invalid_Argument = 0x06 + 0;
    internal const int FT_Err_Unimplemented_Feature = 0x07 + 0;
    internal const int FT_Err_Invalid_Table = 0x08 + 0;
    internal const int FT_Err_Invalid_Offset = 0x09 + 0;
    internal const int FT_Err_Array_Too_Large = 0x0A + 0;
    internal const int FT_Err_Missing_Module = 0x0B + 0;
    internal const int FT_Err_Missing_Property = 0x0C + 0;
    internal const int FT_Err_Invalid_Glyph_Index = 0x10 + 0;
    internal const int FT_Err_Invalid_Character_Code = 0x11 + 0;
    internal const int FT_Err_Invalid_Glyph_Format = 0x12 + 0;
    internal const int FT_Err_Cannot_Render_Glyph = 0x13 + 0;
    internal const int FT_Err_Invalid_Outline = 0x14 + 0;
    internal const int FT_Err_Invalid_Composite = 0x15 + 0;
    internal const int FT_Err_Too_Many_Hints = 0x16 + 0;
    internal const int FT_Err_Invalid_Pixel_Size = 0x17 + 0;
    internal const int FT_Err_Invalid_SVG_Document = 0x18 + 0;
    internal const int FT_Err_Invalid_Handle = 0x20 + 0;
    internal const int FT_Err_Invalid_Library_Handle = 0x21 + 0;
    internal const int FT_Err_Invalid_Driver_Handle = 0x22 + 0;
    internal const int FT_Err_Invalid_Face_Handle = 0x23 + 0;
    internal const int FT_Err_Invalid_Size_Handle = 0x24 + 0;
    internal const int FT_Err_Invalid_Slot_Handle = 0x25 + 0;
    internal const int FT_Err_Invalid_CharMap_Handle = 0x26 + 0;
    internal const int FT_Err_Invalid_Cache_Handle = 0x27 + 0;
    internal const int FT_Err_Invalid_Stream_Handle = 0x28 + 0;
    internal const int FT_Err_Too_Many_Drivers = 0x30 + 0;
    internal const int FT_Err_Too_Many_Extensions = 0x31 + 0;
    internal const int FT_Err_Out_Of_Memory = 0x40 + 0;
    internal const int FT_Err_Unlisted_Object = 0x41 + 0;
    internal const int FT_Err_Cannot_Open_Stream = 0x51 + 0;
    internal const int FT_Err_Invalid_Stream_Seek = 0x52 + 0;
    internal const int FT_Err_Invalid_Stream_Skip = 0x53 + 0;
    internal const int FT_Err_Invalid_Stream_Read = 0x54 + 0;
    internal const int FT_Err_Invalid_Stream_Operation = 0x55 + 0;
    internal const int FT_Err_Invalid_Frame_Operation = 0x56 + 0;
    internal const int FT_Err_Nested_Frame_Access = 0x57 + 0;
    internal const int FT_Err_Invalid_Frame_Read = 0x58 + 0;
    internal const int FT_Err_Raster_Uninitialized = 0x60 + 0;
    internal const int FT_Err_Raster_Corrupted = 0x61 + 0;
    internal const int FT_Err_Raster_Overflow = 0x62 + 0;
    internal const int FT_Err_Raster_Negative_Height = 0x63 + 0;
    internal const int FT_Err_Too_Many_Caches = 0x70 + 0;
    internal const int FT_Err_Invalid_Opcode = 0x80 + 0;
    internal const int FT_Err_Too_Few_Arguments = 0x81 + 0;
    internal const int FT_Err_Stack_Overflow = 0x82 + 0;
    internal const int FT_Err_Code_Overflow = 0x83 + 0;
    internal const int FT_Err_Bad_Argument = 0x84 + 0;
    internal const int FT_Err_Divide_By_Zero = 0x85 + 0;
    internal const int FT_Err_Invalid_Reference = 0x86 + 0;
    internal const int FT_Err_Debug_OpCode = 0x87 + 0;
    internal const int FT_Err_ENDF_In_Exec_Stream = 0x88 + 0;
    internal const int FT_Err_Nested_DEFS = 0x89 + 0;
    internal const int FT_Err_Invalid_CodeRange = 0x8A + 0;
    internal const int FT_Err_Execution_Too_Long = 0x8B + 0;
    internal const int FT_Err_Too_Many_Function_Defs = 0x8C + 0;
    internal const int FT_Err_Too_Many_Instruction_Defs = 0x8D + 0;
    internal const int FT_Err_Table_Missing = 0x8E + 0;
    internal const int FT_Err_Horiz_Header_Missing = 0x8F + 0;
    internal const int FT_Err_Locations_Missing = 0x90 + 0;
    internal const int FT_Err_Name_Table_Missing = 0x91 + 0;
    internal const int FT_Err_CMap_Table_Missing = 0x92 + 0;
    internal const int FT_Err_Hmtx_Table_Missing = 0x93 + 0;
    internal const int FT_Err_Post_Table_Missing = 0x94 + 0;
    internal const int FT_Err_Invalid_Horiz_Metrics = 0x95 + 0;
    internal const int FT_Err_Invalid_CharMap_Format = 0x96 + 0;
    internal const int FT_Err_Invalid_PPem = 0x97 + 0;
    internal const int FT_Err_Invalid_Vert_Metrics = 0x98 + 0;
    internal const int FT_Err_Could_Not_Find_Context = 0x99 + 0;
    internal const int FT_Err_Invalid_Post_Table_Format = 0x9A + 0;
    internal const int FT_Err_Invalid_Post_Table = 0x9B + 0;
    internal const int FT_Err_DEF_In_Glyf_Bytecode = 0x9C + 0;
    internal const int FT_Err_Missing_Bitmap = 0x9D + 0;
    internal const int FT_Err_Missing_SVG_Hooks = 0x9E + 0;
    internal const int FT_Err_Syntax_Error = 0xA0 + 0;
    internal const int FT_Err_Stack_Underflow = 0xA1 + 0;
    internal const int FT_Err_Ignore = 0xA2 + 0;
    internal const int FT_Err_No_Unicode_Glyph_Name = 0xA3 + 0;
    internal const int FT_Err_Glyph_Too_Big = 0xA4 + 0;
    internal const int FT_Err_Missing_Startfont_Field = 0xB0 + 0;
    internal const int FT_Err_Missing_Font_Field = 0xB1 + 0;
    internal const int FT_Err_Missing_Size_Field = 0xB2 + 0;
    internal const int FT_Err_Missing_Fontboundingbox_Field = 0xB3 + 0;
    internal const int FT_Err_Missing_Chars_Field = 0xB4 + 0;
    internal const int FT_Err_Missing_Startchar_Field = 0xB5 + 0;
    internal const int FT_Err_Missing_Encoding_Field = 0xB6 + 0;
    internal const int FT_Err_Missing_Bbx_Field = 0xB7 + 0;
    internal const int FT_Err_Bbx_Too_Big = 0xB8 + 0;
    internal const int FT_Err_Corrupted_Font_Header = 0xB9 + 0;
    internal const int FT_Err_Corrupted_Font_Glyphs = 0xBA + 0;
    internal const int FT_Err_Max = 187;

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Error_String([NativeTypeName("FT_Error")] SharpFont.Error error_code);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Init_FreeType([NativeTypeName("FT_Library *")] FT_LibraryRec_** alibrary);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Done_FreeType([NativeTypeName("FT_Library")] FT_LibraryRec_* library);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Face([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const char *")] sbyte* filepathname, [NativeTypeName("FT_Long")] nint face_index, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Memory_Face([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_Byte *")] byte* file_base, [NativeTypeName("FT_Long")] nint file_size, [NativeTypeName("FT_Long")] nint face_index, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Open_Face([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_Open_Args *")] FT_Open_Args_* args, [NativeTypeName("FT_Long")] nint face_index, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Attach_File([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("const char *")] sbyte* filepathname);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Attach_Stream([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("const FT_Open_Args *")] FT_Open_Args_* parameters);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Reference_Face([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Done_Face([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Select_Size([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Int")] int strike_index);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Request_Size([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Size_Request")] SharpFont.SizeRequest* req);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Char_Size([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_F26Dot6")] nint char_width, [NativeTypeName("FT_F26Dot6")] nint char_height, [NativeTypeName("FT_UInt")] uint horz_resolution, [NativeTypeName("FT_UInt")] uint vert_resolution);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Pixel_Sizes([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint pixel_width, [NativeTypeName("FT_UInt")] uint pixel_height);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Load_Glyph([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint glyph_index, [NativeTypeName("FT_Int32")] int load_flags);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Load_Char([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint char_code, [NativeTypeName("FT_Int32")] int load_flags);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Transform([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Matrix *")] SharpFont.FTMatrix* matrix, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* delta);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Get_Transform([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Matrix *")] SharpFont.FTMatrix* matrix, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* delta);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Render_Glyph([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot, [NativeTypeName("FT_Render_Mode")] SharpFont.RenderMode render_mode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Kerning([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint left_glyph, [NativeTypeName("FT_UInt")] uint right_glyph, [NativeTypeName("FT_UInt")] uint kern_mode, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* akerning);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Track_Kerning([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Fixed")] nint point_size, [NativeTypeName("FT_Int")] int degree, [NativeTypeName("FT_Fixed *")] nint* akerning);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Select_Charmap([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Encoding")] SharpFont.Encoding encoding);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Charmap([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_CharMap")] FT_CharMapRec_* charmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Get_Charmap_Index([NativeTypeName("FT_CharMap")] FT_CharMapRec_* charmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Get_Char_Index([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint charcode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ULong")]
    public static extern nuint FT_Get_First_Char([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt *")] uint* agindex);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ULong")]
    public static extern nuint FT_Get_Next_Char([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint char_code, [NativeTypeName("FT_UInt *")] uint* agindex);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Face_Properties([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_properties, [NativeTypeName("FT_Parameter *")] FT_Parameter_* properties);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Get_Name_Index([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("const FT_String *")] sbyte* glyph_name);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Glyph_Name([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint glyph_index, [NativeTypeName("FT_Pointer")] void* buffer, [NativeTypeName("FT_UInt")] uint buffer_max);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Get_Postscript_Name([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_SubGlyph_Info([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* glyph, [NativeTypeName("FT_UInt")] uint sub_index, [NativeTypeName("FT_Int *")] int* p_index, [NativeTypeName("FT_UInt *")] uint* p_flags, [NativeTypeName("FT_Int *")] int* p_arg1, [NativeTypeName("FT_Int *")] int* p_arg2, [NativeTypeName("FT_Matrix *")] SharpFont.FTMatrix* p_transform);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UShort")]
    public static extern ushort FT_Get_FSType_Flags([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Face_GetCharVariantIndex([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint charcode, [NativeTypeName("FT_ULong")] nuint variantSelector);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Face_GetCharVariantIsDefault([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint charcode, [NativeTypeName("FT_ULong")] nuint variantSelector);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt32 *")]
    public static extern uint* FT_Face_GetVariantSelectors([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt32 *")]
    public static extern uint* FT_Face_GetVariantsOfChar([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint charcode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt32 *")]
    public static extern uint* FT_Face_GetCharsOfVariant([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint variantSelector);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_MulDiv([NativeTypeName("FT_Long")] nint a, [NativeTypeName("FT_Long")] nint b, [NativeTypeName("FT_Long")] nint c);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_MulFix([NativeTypeName("FT_Long")] nint a, [NativeTypeName("FT_Long")] nint b);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_DivFix([NativeTypeName("FT_Long")] nint a, [NativeTypeName("FT_Long")] nint b);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_RoundFix([NativeTypeName("FT_Fixed")] nint a);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_CeilFix([NativeTypeName("FT_Fixed")] nint a);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_FloorFix([NativeTypeName("FT_Fixed")] nint a);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Transform([NativeTypeName("FT_Vector *")] SharpFont.FTVector* vector, [NativeTypeName("const FT_Matrix *")] SharpFont.FTMatrix* matrix);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Library_Version([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Int *")] int* amajor, [NativeTypeName("FT_Int *")] int* aminor, [NativeTypeName("FT_Int *")] int* apatch);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Face_CheckTrueTypePatents([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Face_SetUnpatentedHinting([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Bool")] byte value);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Advance([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Int32")] int load_flags, [NativeTypeName("FT_Fixed *")] nint* padvance);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Advances([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint start, [NativeTypeName("FT_UInt")] uint count, [NativeTypeName("FT_Int32")] int load_flags, [NativeTypeName("FT_Fixed *")] nint* padvances);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Get_BBox([NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_BBox *")] SharpFont.BBox* abbox);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_BDF_Charset_ID([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("const char **")] sbyte** acharset_encoding, [NativeTypeName("const char **")] sbyte** acharset_registry);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_BDF_Property([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("const char *")] sbyte* prop_name, [NativeTypeName("BDF_PropertyRec *")] BDF_PropertyRec_* aproperty);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Palette_Data_Get([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Palette_Data *")] FT_Palette_Data_* apalette);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Palette_Select([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UShort")] ushort palette_index, [NativeTypeName("FT_Color **")] FT_Color_** apalette);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Palette_Set_Foreground_Color([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Color")] FT_Color_ foreground_color);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Color_Glyph_Layer([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint base_glyph, [NativeTypeName("FT_UInt *")] uint* aglyph_index, [NativeTypeName("FT_UInt *")] uint* acolor_index, [NativeTypeName("FT_LayerIterator *")] FT_LayerIterator_* iterator);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Color_Glyph_Paint([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint base_glyph, [NativeTypeName("FT_Color_Root_Transform")] FT_Color_Root_Transform_ root_transform, [NativeTypeName("FT_OpaquePaint *")] FT_Opaque_Paint_* paint);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Color_Glyph_ClipBox([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint base_glyph, [NativeTypeName("FT_ClipBox *")] FT_ClipBox_* clip_box);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Paint_Layers([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_LayerIterator *")] FT_LayerIterator_* iterator, [NativeTypeName("FT_OpaquePaint *")] FT_Opaque_Paint_* paint);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Colorline_Stops([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ColorStop *")] FT_ColorStop_* color_stop, [NativeTypeName("FT_ColorStopIterator *")] FT_ColorStopIterator_* iterator);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Bool")]
    public static extern byte FT_Get_Paint([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_OpaquePaint")] FT_Opaque_Paint_ opaque_paint, [NativeTypeName("FT_COLR_Paint *")] FT_COLR_Paint_* paint);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Bitmap_Init([NativeTypeName("FT_Bitmap *")] FT_Bitmap_* abitmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Bitmap_New([NativeTypeName("FT_Bitmap *")] FT_Bitmap_* abitmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Bitmap_Copy([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap_* source, [NativeTypeName("FT_Bitmap *")] FT_Bitmap_* target);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Bitmap_Embolden([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Bitmap *")] FT_Bitmap_* bitmap, [NativeTypeName("FT_Pos")] nint xStrength, [NativeTypeName("FT_Pos")] nint yStrength);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Bitmap_Convert([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap_* source, [NativeTypeName("FT_Bitmap *")] FT_Bitmap_* target, [NativeTypeName("FT_Int")] int alignment);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Bitmap_Blend([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap_* source, [NativeTypeName("const FT_Vector")] SharpFont.FTVector source_offset, [NativeTypeName("FT_Bitmap *")] FT_Bitmap_* target, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* atarget_offset, [NativeTypeName("FT_Color")] FT_Color_ color);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_GlyphSlot_Own_Bitmap([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Bitmap_Done([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Bitmap *")] FT_Bitmap_* bitmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stream_OpenBzip2([NativeTypeName("FT_Stream")] FT_StreamRec_* stream, [NativeTypeName("FT_Stream")] FT_StreamRec_* source);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Glyph([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Glyph_Format")] SharpFont.GlyphFormat format, [NativeTypeName("FT_Glyph *")] FT_GlyphRec_** aglyph);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Glyph([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot, [NativeTypeName("FT_Glyph *")] FT_GlyphRec_** aglyph);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Glyph_Copy([NativeTypeName("FT_Glyph")] FT_GlyphRec_* source, [NativeTypeName("FT_Glyph *")] FT_GlyphRec_** target);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Glyph_Transform([NativeTypeName("FT_Glyph")] FT_GlyphRec_* glyph, [NativeTypeName("const FT_Matrix *")] SharpFont.FTMatrix* matrix, [NativeTypeName("const FT_Vector *")] SharpFont.FTVector* delta);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Glyph_Get_CBox([NativeTypeName("FT_Glyph")] FT_GlyphRec_* glyph, [NativeTypeName("FT_UInt")] uint bbox_mode, [NativeTypeName("FT_BBox *")] SharpFont.BBox* acbox);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Glyph_To_Bitmap([NativeTypeName("FT_Glyph *")] FT_GlyphRec_** the_glyph, [NativeTypeName("FT_Render_Mode")] SharpFont.RenderMode render_mode, [NativeTypeName("const FT_Vector *")] SharpFont.FTVector* origin, [NativeTypeName("FT_Bool")] byte destroy);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Done_Glyph([NativeTypeName("FT_Glyph")] FT_GlyphRec_* glyph);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Matrix_Multiply([NativeTypeName("const FT_Matrix *")] SharpFont.FTMatrix* a, [NativeTypeName("FT_Matrix *")] SharpFont.FTMatrix* b);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Matrix_Invert([NativeTypeName("FT_Matrix *")] SharpFont.FTMatrix* matrix);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_Manager_New([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_UInt")] uint max_faces, [NativeTypeName("FT_UInt")] uint max_sizes, [NativeTypeName("FT_ULong")] nuint max_bytes, [NativeTypeName("FTC_Face_Requester")] delegate* unmanaged[Cdecl]<void*, FT_LibraryRec_*, void*, FT_FaceRec_**, SharpFont.Error> requester, [NativeTypeName("FT_Pointer")] void* req_data, [NativeTypeName("FTC_Manager *")] FTC_ManagerRec_** amanager);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Manager_Reset([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Manager_Done([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_Manager_LookupFace([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_FaceID")] void* face_id, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_Manager_LookupSize([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_Scaler")] FTC_ScalerRec_* scaler, [NativeTypeName("FT_Size *")] FT_SizeRec_** asize);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Node_Unref([NativeTypeName("FTC_Node")] FTC_NodeRec_* node, [NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FTC_Manager_RemoveFaceID([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_FaceID")] void* face_id);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_CMapCache_New([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_CMapCache *")] FTC_CMapCacheRec_** acache);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FTC_CMapCache_Lookup([NativeTypeName("FTC_CMapCache")] FTC_CMapCacheRec_* cache, [NativeTypeName("FTC_FaceID")] void* face_id, [NativeTypeName("FT_Int")] int cmap_index, [NativeTypeName("FT_UInt32")] uint char_code);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_ImageCache_New([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_ImageCache *")] FTC_ImageCacheRec_** acache);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_ImageCache_Lookup([NativeTypeName("FTC_ImageCache")] FTC_ImageCacheRec_* cache, [NativeTypeName("FTC_ImageType")] FTC_ImageTypeRec_* type, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Glyph *")] FT_GlyphRec_** aglyph, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_ImageCache_LookupScaler([NativeTypeName("FTC_ImageCache")] FTC_ImageCacheRec_* cache, [NativeTypeName("FTC_Scaler")] FTC_ScalerRec_* scaler, [NativeTypeName("FT_ULong")] nuint load_flags, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Glyph *")] FT_GlyphRec_** aglyph, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_SBitCache_New([NativeTypeName("FTC_Manager")] FTC_ManagerRec_* manager, [NativeTypeName("FTC_SBitCache *")] FTC_SBitCacheRec_** acache);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_SBitCache_Lookup([NativeTypeName("FTC_SBitCache")] FTC_SBitCacheRec_* cache, [NativeTypeName("FTC_ImageType")] FTC_ImageTypeRec_* type, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FTC_SBit *")] FTC_SBitRec_** sbit, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FTC_SBitCache_LookupScaler([NativeTypeName("FTC_SBitCache")] FTC_SBitCacheRec_* cache, [NativeTypeName("FTC_Scaler")] FTC_ScalerRec_* scaler, [NativeTypeName("FT_ULong")] nuint load_flags, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FTC_SBit *")] FTC_SBitRec_** sbit, [NativeTypeName("FTC_Node *")] FTC_NodeRec_** anode);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_CID_Registry_Ordering_Supplement([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("const char **")] sbyte** registry, [NativeTypeName("const char **")] sbyte** ordering, [NativeTypeName("FT_Int *")] int* supplement);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_CID_Is_Internally_CID_Keyed([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Bool *")] byte* is_cid);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_CID_From_Glyph_Index([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint glyph_index, [NativeTypeName("FT_UInt *")] uint* cid);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Get_Font_Format([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FT_Get_X11_Font_Format([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Get_Gasp([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint ppem);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_TrueTypeGX_Validate([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint validation_flags, [NativeTypeName("FT_Bytes[10]")] byte** tables, [NativeTypeName("FT_UInt")] uint table_length);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_TrueTypeGX_Free([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Bytes")] byte* table);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_ClassicKern_Validate([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint validation_flags, [NativeTypeName("FT_Bytes *")] byte** ckern_table);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_ClassicKern_Free([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Bytes")] byte* table);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stream_OpenGzip([NativeTypeName("FT_Stream")] FT_StreamRec_* stream, [NativeTypeName("FT_Stream")] FT_StreamRec_* source);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Gzip_Uncompress([NativeTypeName("FT_Memory")] FT_MemoryRec_* memory, [NativeTypeName("FT_Byte *")] byte* output, [NativeTypeName("FT_ULong *")] nuint* output_len, [NativeTypeName("const FT_Byte *")] byte* input, [NativeTypeName("FT_ULong")] nuint input_len);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Library_SetLcdFilter([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_LcdFilter")] SharpFont.LcdFilter filter);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Library_SetLcdFilterWeights([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("unsigned char *")] byte* weights);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Library_SetLcdGeometry([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Vector[3]")] SharpFont.FTVector* sub);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ListNode")]
    public static extern FT_ListNodeRec_* FT_List_Find([NativeTypeName("FT_List")] FT_ListRec_* list, void* data);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Add([NativeTypeName("FT_List")] FT_ListRec_* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec_* node);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Insert([NativeTypeName("FT_List")] FT_ListRec_* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec_* node);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Remove([NativeTypeName("FT_List")] FT_ListRec_* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec_* node);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Up([NativeTypeName("FT_List")] FT_ListRec_* list, [NativeTypeName("FT_ListNode")] FT_ListNodeRec_* node);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_List_Iterate([NativeTypeName("FT_List")] FT_ListRec_* list, [NativeTypeName("FT_List_Iterator")] delegate* unmanaged[Cdecl]<FT_ListNodeRec_*, void*, SharpFont.Error> iterator, void* user);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_List_Finalize([NativeTypeName("FT_List")] FT_ListRec_* list, [NativeTypeName("FT_List_Destructor")] delegate* unmanaged[Cdecl]<FT_MemoryRec_*, void*, void*, void> destroy, [NativeTypeName("FT_Memory")] FT_MemoryRec_* memory, void* user);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Trace_Set_Level([NativeTypeName("const char *")] sbyte* tracing_level);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Trace_Set_Default_Level();

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Log_Handler([NativeTypeName("FT_Custom_Log_Handler")] delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*, void> handler);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Default_Log_Handler();

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stream_OpenLZW([NativeTypeName("FT_Stream")] FT_StreamRec_* stream, [NativeTypeName("FT_Stream")] FT_StreamRec_* source);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Face_From_FOND([NativeTypeName("FT_Library")] FT_LibraryRec_* library, void* fond, [NativeTypeName("FT_Long")] nint face_index, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_GetFile_From_Mac_Name([NativeTypeName("const char *")] sbyte* fontName, void* pathSpec, [NativeTypeName("FT_Long *")] nint* face_index);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_GetFile_From_Mac_ATS_Name([NativeTypeName("const char *")] sbyte* fontName, void* pathSpec, [NativeTypeName("FT_Long *")] nint* face_index);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_GetFilePath_From_Mac_ATS_Name([NativeTypeName("const char *")] sbyte* fontName, [NativeTypeName("uint8_t *")] byte* path, [NativeTypeName("uint32_t")] uint maxPathSize, [NativeTypeName("FT_Long *")] nint* face_index);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Face_From_FSSpec([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const void *")] void* spec, [NativeTypeName("FT_Long")] nint face_index, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Face_From_FSRef([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const void *")] void* @ref, [NativeTypeName("FT_Long")] nint face_index, [NativeTypeName("FT_Face *")] FT_FaceRec_** aface);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Multi_Master([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Multi_Master *")] FT_Multi_Master_* amaster);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_MM_Var([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_MM_Var **")] FT_MM_Var_** amaster);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Done_MM_Var([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_MM_Var *")] FT_MM_Var_* amaster);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_MM_Design_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Long *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Var_Design_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Var_Design_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_MM_Blend_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_MM_Blend_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Var_Blend_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Var_Blend_Coordinates([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint num_coords, [NativeTypeName("FT_Fixed *")] nint* coords);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_MM_WeightVector([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint len, [NativeTypeName("FT_Fixed *")] nint* weightvector);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_MM_WeightVector([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt *")] uint* len, [NativeTypeName("FT_Fixed *")] nint* weightvector);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Var_Axis_Flags([NativeTypeName("FT_MM_Var *")] FT_MM_Var_* master, [NativeTypeName("FT_UInt")] uint axis_index, [NativeTypeName("FT_UInt *")] uint* flags);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Named_Instance([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint instance_index);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Default_Named_Instance([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt *")] uint* instance_index);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Add_Module([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_Module_Class *")] FT_Module_Class_* clazz);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Module")]
    public static extern FT_ModuleRec_* FT_Get_Module([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const char *")] sbyte* module_name);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Remove_Module([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Module")] FT_ModuleRec_* module);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Property_Set([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_String *")] sbyte* module_name, [NativeTypeName("const FT_String *")] sbyte* property_name, [NativeTypeName("const void *")] void* value);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Property_Get([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("const FT_String *")] sbyte* module_name, [NativeTypeName("const FT_String *")] sbyte* property_name, void* value);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Default_Properties([NativeTypeName("FT_Library")] FT_LibraryRec_* library);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Reference_Library([NativeTypeName("FT_Library")] FT_LibraryRec_* library);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Library([NativeTypeName("FT_Memory")] FT_MemoryRec_* memory, [NativeTypeName("FT_Library *")] FT_LibraryRec_** alibrary);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Done_Library([NativeTypeName("FT_Library")] FT_LibraryRec_* library);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Set_Debug_Hook([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_UInt")] uint hook_index, [NativeTypeName("FT_DebugHook_Func")] delegate* unmanaged[Cdecl]<void*, SharpFont.Error> debug_hook);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Add_Default_Modules([NativeTypeName("FT_Library")] FT_LibraryRec_* library);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_TrueTypeEngineType")]
    public static extern SharpFont.TrueType.EngineType FT_Get_TrueType_Engine_Type([NativeTypeName("FT_Library")] FT_LibraryRec_* library);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_OpenType_Validate([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint validation_flags, [NativeTypeName("FT_Bytes *")] byte** BASE_table, [NativeTypeName("FT_Bytes *")] byte** GDEF_table, [NativeTypeName("FT_Bytes *")] byte** GPOS_table, [NativeTypeName("FT_Bytes *")] byte** GSUB_table, [NativeTypeName("FT_Bytes *")] byte** JSTF_table);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_OpenType_Free([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Bytes")] byte* table);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Decompose([NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("const FT_Outline_Funcs *")] FT_Outline_Funcs_* func_interface, void* user);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_New([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_UInt")] uint numPoints, [NativeTypeName("FT_Int")] int numContours, [NativeTypeName("FT_Outline *")] FT_Outline_* anoutline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Done([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Check([NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Get_CBox([NativeTypeName("const FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_BBox *")] SharpFont.BBox* acbox);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Translate([NativeTypeName("const FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_Pos")] nint xOffset, [NativeTypeName("FT_Pos")] nint yOffset);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Copy([NativeTypeName("const FT_Outline *")] FT_Outline_* source, [NativeTypeName("FT_Outline *")] FT_Outline_* target);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Transform([NativeTypeName("const FT_Outline *")] FT_Outline_* outline, [NativeTypeName("const FT_Matrix *")] SharpFont.FTMatrix* matrix);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Embolden([NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_Pos")] nint strength);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_EmboldenXY([NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_Pos")] nint xstrength, [NativeTypeName("FT_Pos")] nint ystrength);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Outline_Reverse([NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Get_Bitmap([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("const FT_Bitmap *")] FT_Bitmap_* abitmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Outline_Render([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_Raster_Params *")] FT_Raster_Params_* @params);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Orientation")]
    public static extern SharpFont.Orientation FT_Outline_Get_Orientation([NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_PFR_Metrics([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt *")] uint* aoutline_resolution, [NativeTypeName("FT_UInt *")] uint* ametrics_resolution, [NativeTypeName("FT_Fixed *")] nint* ametrics_x_scale, [NativeTypeName("FT_Fixed *")] nint* ametrics_y_scale);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_PFR_Kerning([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint left, [NativeTypeName("FT_UInt")] uint right, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* avector);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_PFR_Advance([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint gindex, [NativeTypeName("FT_Pos *")] nint* aadvance);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Renderer")]
    public static extern FT_RendererRec_* FT_Get_Renderer([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Glyph_Format")] SharpFont.GlyphFormat format);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Set_Renderer([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Renderer")] FT_RendererRec_* renderer, [NativeTypeName("FT_UInt")] uint num_params, [NativeTypeName("FT_Parameter *")] FT_Parameter_* parameters);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_New_Size([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Size *")] FT_SizeRec_** size);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Done_Size([NativeTypeName("FT_Size")] FT_SizeRec_* size);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Activate_Size([NativeTypeName("FT_Size")] FT_SizeRec_* size);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_UInt")]
    public static extern uint FT_Get_Sfnt_Name_Count([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Sfnt_Name([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint idx, [NativeTypeName("FT_SfntName *")] FT_SfntName_* aname);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_Sfnt_LangTag([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint langID, [NativeTypeName("FT_SfntLangTag *")] FT_SfntLangTag_* alangTag);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_StrokerBorder")]
    public static extern SharpFont.StrokerBorder FT_Outline_GetInsideBorder([NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_StrokerBorder")]
    public static extern SharpFont.StrokerBorder FT_Outline_GetOutsideBorder([NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_New([NativeTypeName("FT_Library")] FT_LibraryRec_* library, [NativeTypeName("FT_Stroker *")] FT_StrokerRec_** astroker);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Set([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Fixed")] nint radius, [NativeTypeName("FT_Stroker_LineCap")] SharpFont.StrokerLineCap line_cap, [NativeTypeName("FT_Stroker_LineJoin")] SharpFont.StrokerLineJoin line_join, [NativeTypeName("FT_Fixed")] nint miter_limit);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Rewind([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_ParseOutline([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Outline *")] FT_Outline_* outline, [NativeTypeName("FT_Bool")] byte opened);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_BeginSubPath([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* to, [NativeTypeName("FT_Bool")] byte open);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_EndSubPath([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_LineTo([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* to);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_ConicTo([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* control, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* to);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_CubicTo([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* control1, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* control2, [NativeTypeName("FT_Vector *")] SharpFont.FTVector* to);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_GetBorderCounts([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_StrokerBorder")] SharpFont.StrokerBorder border, [NativeTypeName("FT_UInt *")] uint* anum_points, [NativeTypeName("FT_UInt *")] uint* anum_contours);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_ExportBorder([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_StrokerBorder")] SharpFont.StrokerBorder border, [NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Stroker_GetCounts([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_UInt *")] uint* anum_points, [NativeTypeName("FT_UInt *")] uint* anum_contours);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Export([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Outline *")] FT_Outline_* outline);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Stroker_Done([NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Glyph_Stroke([NativeTypeName("FT_Glyph *")] FT_GlyphRec_** pglyph, [NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Bool")] byte destroy);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Glyph_StrokeBorder([NativeTypeName("FT_Glyph *")] FT_GlyphRec_** pglyph, [NativeTypeName("FT_Stroker")] FT_StrokerRec_* stroker, [NativeTypeName("FT_Bool")] byte inside, [NativeTypeName("FT_Bool")] byte destroy);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_Embolden([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_AdjustWeight([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot, [NativeTypeName("FT_Fixed")] nint xdelta, [NativeTypeName("FT_Fixed")] nint ydelta);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_Oblique([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_GlyphSlot_Slant([NativeTypeName("FT_GlyphSlot")] FT_GlyphSlotRec_* slot, [NativeTypeName("FT_Fixed")] nint xslant, [NativeTypeName("FT_Fixed")] nint yslant);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Sin([NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Cos([NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Tan([NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Angle")]
    public static extern nint FT_Atan2([NativeTypeName("FT_Fixed")] nint x, [NativeTypeName("FT_Fixed")] nint y);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Angle")]
    public static extern nint FT_Angle_Diff([NativeTypeName("FT_Angle")] nint angle1, [NativeTypeName("FT_Angle")] nint angle2);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Unit([NativeTypeName("FT_Vector *")] SharpFont.FTVector* vec, [NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Rotate([NativeTypeName("FT_Vector *")] SharpFont.FTVector* vec, [NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Fixed")]
    public static extern nint FT_Vector_Length([NativeTypeName("FT_Vector *")] SharpFont.FTVector* vec);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_Polarize([NativeTypeName("FT_Vector *")] SharpFont.FTVector* vec, [NativeTypeName("FT_Fixed *")] nint* length, [NativeTypeName("FT_Angle *")] nint* angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FT_Vector_From_Polar([NativeTypeName("FT_Vector *")] SharpFont.FTVector* vec, [NativeTypeName("FT_Fixed")] nint length, [NativeTypeName("FT_Angle")] nint angle);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_WinFNT_Header([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_WinFNT_HeaderRec *")] FT_WinFNT_HeaderRec_* aheader);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Int")]
    public static extern int FT_Has_PS_Glyph_Names([NativeTypeName("FT_Face")] FT_FaceRec_* face);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_PS_Font_Info([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("PS_FontInfo")] PS_FontInfoRec_* afont_info);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Get_PS_Font_Private([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("PS_Private")] PS_PrivateRec_* afont_private);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_Get_PS_Font_Value([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("PS_Dict_Keys")] SharpFont.PostScript.DictionaryKeys key, [NativeTypeName("FT_UInt")] uint idx, void* value, [NativeTypeName("FT_Long")] nint value_len);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* FT_Get_Sfnt_Table([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_Sfnt_Tag")] SharpFont.TrueType.SfntTag tag);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Load_Sfnt_Table([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_ULong")] nuint tag, [NativeTypeName("FT_Long")] nint offset, [NativeTypeName("FT_Byte *")] byte* buffer, [NativeTypeName("FT_ULong *")] nuint* length);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Error")]
    public static extern SharpFont.Error FT_Sfnt_Table_Info([NativeTypeName("FT_Face")] FT_FaceRec_* face, [NativeTypeName("FT_UInt")] uint table_index, [NativeTypeName("FT_ULong *")] nuint* tag, [NativeTypeName("FT_ULong *")] nuint* length);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_ULong")]
    public static extern nuint FT_Get_CMap_Language_ID([NativeTypeName("FT_CharMap")] FT_CharMapRec_* charmap);

    [DllImport("freetype6", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FT_Long")]
    public static extern nint FT_Get_CMap_Format([NativeTypeName("FT_CharMap")] FT_CharMapRec_* charmap);
}
