// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:743

namespace UnrealEngine
{
	public  partial class FURL : NativeStructWrapper
	{
		internal FURL(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FURL_bDefaultsInitialized_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Host_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Host_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Map_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Map_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FURL_Op_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Op_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FURL_Port_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Port_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Portal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Portal_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Protocol_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Protocol_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_RedirectURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_RedirectURL_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FURL_Valid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Valid_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_FilterURLString(IntPtr self, string str);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FURL_IsInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FURL_IsLocalInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_StaticExit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_StaticInit(IntPtr self);
		
		#endregion
		
		#region Property
		public static bool bDefaultsInitialized
		{
			get => E_PROP_FURL_bDefaultsInitialized_GET();
		}

		public string Host
		{
			get => E_PROP_FURL_Host_GET(NativePointer);
			set => E_PROP_FURL_Host_SET(NativePointer, value);
		}

		public string Map
		{
			get => E_PROP_FURL_Map_GET(NativePointer);
			set => E_PROP_FURL_Map_SET(NativePointer, value);
		}

		public TArray<string> Op
		{
			get => E_PROP_FURL_Op_GET(NativePointer);
			set => E_PROP_FURL_Op_SET(NativePointer, value);
		}

		public int Port
		{
			get => E_PROP_FURL_Port_GET(NativePointer);
			set => E_PROP_FURL_Port_SET(NativePointer, value);
		}

		public string Portal
		{
			get => E_PROP_FURL_Portal_GET(NativePointer);
			set => E_PROP_FURL_Portal_SET(NativePointer, value);
		}

		public string Protocol
		{
			get => E_PROP_FURL_Protocol_GET(NativePointer);
			set => E_PROP_FURL_Protocol_SET(NativePointer, value);
		}

		public string RedirectURL
		{
			get => E_PROP_FURL_RedirectURL_GET(NativePointer);
			set => E_PROP_FURL_RedirectURL_SET(NativePointer, value);
		}

		public int Valid
		{
			get => E_PROP_FURL_Valid_GET(NativePointer);
			set => E_PROP_FURL_Valid_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Static: Removes any special URL characters from the specified string </para>
		/// <param name="Str">String to be filtered </param>
		/// </summary>
		public void FilterURLString(string str)
			=> E_FURL_FilterURLString(this, str);
		
		
		/// <summary>
		/// <para>Returns whether this URL corresponds to an internal object, i.e. an Unreal </para>
		/// <para>level which this app can try to connect to locally or on the net. If this </para>
		/// <para>is false, the URL refers to an object that a remote application like Internet </para>
		/// <para>Explorer can execute. </para>
		/// </summary>
		public bool IsInternal()
			=> E_FURL_IsInternal(this);
		
		
		/// <summary>
		/// <para>Returns whether this URL corresponds to an internal object on this local </para>
		/// <para>process. In this case, no Internet use is necessary. </para>
		/// </summary>
		public bool IsLocalInternal()
			=> E_FURL_IsLocalInternal(this);
		
		public void StaticExit()
			=> E_FURL_StaticExit(this);
		
		public void StaticInit()
			=> E_FURL_StaticInit(this);
		
		#endregion
		
		public static implicit operator IntPtr(FURL self)
		{
			return self.NativePointer;
		}

		public static implicit operator FURL(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FURL(Adress, false);
		}}}
