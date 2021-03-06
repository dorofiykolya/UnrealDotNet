// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:92

namespace UnrealEngine
{
	public  partial class FBatchedMesh : NativeStructWrapper
	{
		internal FBatchedMesh(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedMesh() :
			base(E_CreateStruct_FBatchedMesh(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedMesh();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBatchedMesh_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedMesh_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FBatchedMesh_MeshIndices_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedMesh_MeshIndices_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FBatchedMesh_MeshVerts_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedMesh_MeshVerts_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedMesh_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedMesh_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public byte DepthPriority
		{
			get => E_PROP_FBatchedMesh_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedMesh_DepthPriority_SET(NativePointer, value);
		}

		public TArray<int> MeshIndices
		{
			get => E_PROP_FBatchedMesh_MeshIndices_GET(NativePointer);
			set => E_PROP_FBatchedMesh_MeshIndices_SET(NativePointer, value);
		}

		public TArray<FVector> MeshVerts
		{
			get => E_PROP_FBatchedMesh_MeshVerts_GET(NativePointer);
			set => E_PROP_FBatchedMesh_MeshVerts_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedMesh_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedMesh_RemainingLifeTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedMesh self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBatchedMesh(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedMesh(Adress, false);
		}}}
