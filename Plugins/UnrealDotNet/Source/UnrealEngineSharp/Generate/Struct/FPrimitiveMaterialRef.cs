// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1840

namespace UnrealEngine
{
	public  partial class FPrimitiveMaterialRef : NativeStructWrapper
	{
		internal FPrimitiveMaterialRef(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPrimitiveMaterialRef() :
			base(E_CreateStruct_FPrimitiveMaterialRef(), false)
		{
		}

		public FPrimitiveMaterialRef(UPrimitiveComponent inPrimitive, int inElementIndex) :
			base(E_CreateStruct_FPrimitiveMaterialRef_UPrimitiveComponent_int32(inPrimitive, inElementIndex), false)
		{
		}

		public FPrimitiveMaterialRef(UDecalComponent inDecal, int inElementIndex) :
			base(E_CreateStruct_FPrimitiveMaterialRef_UDecalComponent_int32(inDecal, inElementIndex), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef_UPrimitiveComponent_int32(IntPtr inPrimitive, int inElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef_UDecalComponent_int32(IntPtr inDecal, int inElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FPrimitiveMaterialRef_Decal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_Decal_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FPrimitiveMaterialRef_Primitive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_Primitive_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public UDecalComponent Decal
		{
			get => E_PROP_FPrimitiveMaterialRef_Decal_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_Decal_SET(NativePointer, value);
		}

		public int ElementIndex
		{
			get => E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(NativePointer, value);
		}

		public UPrimitiveComponent Primitive
		{
			get => E_PROP_FPrimitiveMaterialRef_Primitive_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_Primitive_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPrimitiveMaterialRef self)
		{
			return self.NativePointer;
		}

		public static implicit operator FPrimitiveMaterialRef(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrimitiveMaterialRef(Adress, false);
		}}}
