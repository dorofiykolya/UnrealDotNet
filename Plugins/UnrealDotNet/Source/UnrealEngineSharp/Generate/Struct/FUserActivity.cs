// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3910

namespace UnrealEngine
{
	public  partial class FUserActivity : NativeStructWrapper
	{
		internal FUserActivity(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// </summary>
		public FUserActivity() :
			base(E_CreateStruct_FUserActivity(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance. </para>
		/// </summary>
		public FUserActivity(string inActionName) :
			base(E_CreateStruct_FUserActivity_FString(inActionName), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance with a context other than the default "Game". </para>
		/// </summary>
		public FUserActivity(string inActionName, EUserActivityContext inContext) :
			base(E_CreateStruct_FUserActivity_FString_EUserActivityContext(inActionName, (byte)inContext), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUserActivity();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUserActivity_FString(string inActionName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUserActivity_FString_EUserActivityContext(string inActionName, byte inContext);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FUserActivity_ActionName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FUserActivity_ActionName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FUserActivity_Context_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FUserActivity_Context_SET(IntPtr Ptr, byte Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Describes the user's activity </para>
		/// </summary>
		public string ActionName
		{
			get => E_PROP_FUserActivity_ActionName_GET(NativePointer);
			set => E_PROP_FUserActivity_ActionName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>A game or editor activity? </para>
		/// </summary>
		public EUserActivityContext Context
		{
			get => (EUserActivityContext)E_PROP_FUserActivity_Context_GET(NativePointer);
			set => E_PROP_FUserActivity_Context_SET(NativePointer, (byte)value);
		}

		#endregion
		
		public static implicit operator IntPtr(FUserActivity self)
		{
			return self.NativePointer;
		}

		public static implicit operator FUserActivity(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FUserActivity(Adress, false);
		}}}
