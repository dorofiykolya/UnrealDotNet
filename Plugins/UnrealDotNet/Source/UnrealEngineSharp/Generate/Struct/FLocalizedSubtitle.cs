// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1511

namespace UnrealEngine
{
	public  partial class FLocalizedSubtitle : NativeStructWrapper
	{
		internal FLocalizedSubtitle(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLocalizedSubtitle() :
			base(E_CreateStruct_FLocalizedSubtitle(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalizedSubtitle();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FLocalizedSubtitle_LanguageExt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLocalizedSubtitle_LanguageExt_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FLocalizedSubtitle_Subtitles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLocalizedSubtitle_Subtitles_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public string LanguageExt
		{
			get => E_PROP_FLocalizedSubtitle_LanguageExt_GET(NativePointer);
			set => E_PROP_FLocalizedSubtitle_LanguageExt_SET(NativePointer, value);
		}

		public TArray<FSubtitleCue> Subtitles
		{
			get => E_PROP_FLocalizedSubtitle_Subtitles_GET(NativePointer);
			set => E_PROP_FLocalizedSubtitle_Subtitles_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLocalizedSubtitle self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLocalizedSubtitle(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLocalizedSubtitle(Adress, false);
		}}}
