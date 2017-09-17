using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSpriteCategoryInfo : NativeStructWrapper
	{
		public FSpriteCategoryInfo() : base(E_CreateStruct_FSpriteCategoryInfo(), false)
		{
		}

		internal FSpriteCategoryInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSpriteCategoryInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FSpriteCategoryInfo_Category_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSpriteCategoryInfo_Category_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FSpriteCategoryInfo_Description_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSpriteCategoryInfo_Description_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FSpriteCategoryInfo_DisplayName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSpriteCategoryInfo_DisplayName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string Category
		{
			get => E_PROP_FSpriteCategoryInfo_Category_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_Category_SET(NativePointer, value);
		}

		public string Description
		{
			get => E_PROP_FSpriteCategoryInfo_Description_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_Description_SET(NativePointer, value);
		}

		public string DisplayName
		{
			get => E_PROP_FSpriteCategoryInfo_DisplayName_GET(NativePointer);
			set => E_PROP_FSpriteCategoryInfo_DisplayName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSpriteCategoryInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSpriteCategoryInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSpriteCategoryInfo(Adress, false);
		}}}
