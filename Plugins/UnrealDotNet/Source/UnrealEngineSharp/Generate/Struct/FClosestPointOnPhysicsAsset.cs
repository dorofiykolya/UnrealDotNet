// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:224

namespace UnrealEngine
{
	public  partial class FClosestPointOnPhysicsAsset : NativeStructWrapper
	{
		internal FClosestPointOnPhysicsAsset(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClosestPointOnPhysicsAsset() :
			base(E_CreateStruct_FClosestPointOnPhysicsAsset(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClosestPointOnPhysicsAsset();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClosestPointOnPhysicsAsset_BoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_BoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The name of the bone associated with the closest body </para>
		/// </summary>
		public string BoneName
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_BoneName_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_BoneName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The closest point in world space </para>
		/// </summary>
		public FVector ClosestWorldPosition
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The distance of the closest point and the original world position. 0 Indicates world position is inside the closest body. </para>
		/// </summary>
		public float Distance
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The normal associated with the surface of the closest body </para>
		/// </summary>
		public FVector Normal
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FClosestPointOnPhysicsAsset self)
		{
			return self.NativePointer;
		}

		public static implicit operator FClosestPointOnPhysicsAsset(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClosestPointOnPhysicsAsset(Adress, false);
		}}}
