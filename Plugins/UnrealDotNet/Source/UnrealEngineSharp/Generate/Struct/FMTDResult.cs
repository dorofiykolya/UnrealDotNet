// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2189

namespace UnrealEngine
{
	public  partial class FMTDResult : NativeStructWrapper
	{
		internal FMTDResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FMTDResult() :
			base(E_CreateStruct_FMTDResult(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMTDResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMTDResult_Direction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMTDResult_Direction_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMTDResult_Distance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMTDResult_Distance_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public FVector Direction
		{
			get => E_PROP_FMTDResult_Direction_GET(NativePointer);
			set => E_PROP_FMTDResult_Direction_SET(NativePointer, value);
		}

		public float Distance
		{
			get => E_PROP_FMTDResult_Distance_GET(NativePointer);
			set => E_PROP_FMTDResult_Distance_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FMTDResult self)
		{
			return self.NativePointer;
		}

		public static implicit operator FMTDResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMTDResult(Adress, false);
		}}}
