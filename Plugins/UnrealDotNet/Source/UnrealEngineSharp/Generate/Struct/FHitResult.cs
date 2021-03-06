// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1877

namespace UnrealEngine
{
	public  partial class FHitResult : NativeStructWrapper
	{
		internal FHitResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FHitResult() :
			base(E_CreateStruct_FHitResult(), false)
		{
		}

		public FHitResult(float inTime) :
			base(E_CreateStruct_FHitResult_float(inTime), false)
		{
		}

		public FHitResult(FVector start, FVector end) :
			base(E_CreateStruct_FHitResult_FVector_FVector(start, end), false)
		{
		}

		
		/// <summary>
		/// <para>Ctor for easily creating "fake" hits from limited data. </para>
		/// </summary>
		public FHitResult(AActor inActor, UPrimitiveComponent inComponent, FVector hitLoc, FVector hitNorm) :
			base(E_CreateStruct_FHitResult_AActor_UPrimitiveComponent_FVector_FVector(inActor, inComponent, hitLoc, hitNorm), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult_float(float inTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult_FVector_FVector(IntPtr start, IntPtr end);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult_AActor_UPrimitiveComponent_FVector_FVector(IntPtr inActor, IntPtr inComponent, IntPtr hitLoc, IntPtr hitNorm);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHitResult_bBlockingHit_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_bBlockingHit_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FHitResult_BoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_BoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHitResult_bStartPenetrating_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_bStartPenetrating_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHitResult_Distance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_Distance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FHitResult_FaceIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_FaceIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FHitResult_Item_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_Item_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FHitResult_MyBoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_MyBoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHitResult_PenetrationDepth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_PenetrationDepth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHitResult_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_Time_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FHitResult_GetActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FHitResult_GetComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FHitResult_GetFirstBlockingHit(IntPtr self, IntPtr inHits);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FHitResult_GetNumBlockingHits(IntPtr self, IntPtr inHits);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FHitResult_GetNumOverlapHits(IntPtr self, IntPtr inHits);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FHitResult_GetReversedHit(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FHitResult_Init(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FHitResult_Init_o1(IntPtr self, IntPtr start, IntPtr end);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FHitResult_IsValidBlockingHit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FHitResult_Reset(IntPtr self, float inTime, bool bPreserveTraceData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FHitResult_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		public byte bBlockingHit
		{
			get => E_PROP_FHitResult_bBlockingHit_GET(NativePointer);
			set => E_PROP_FHitResult_bBlockingHit_SET(NativePointer, value);
		}

		public string BoneName
		{
			get => E_PROP_FHitResult_BoneName_GET(NativePointer);
			set => E_PROP_FHitResult_BoneName_SET(NativePointer, value);
		}

		public byte bStartPenetrating
		{
			get => E_PROP_FHitResult_bStartPenetrating_GET(NativePointer);
			set => E_PROP_FHitResult_bStartPenetrating_SET(NativePointer, value);
		}

		public float Distance
		{
			get => E_PROP_FHitResult_Distance_GET(NativePointer);
			set => E_PROP_FHitResult_Distance_SET(NativePointer, value);
		}

		public int FaceIndex
		{
			get => E_PROP_FHitResult_FaceIndex_GET(NativePointer);
			set => E_PROP_FHitResult_FaceIndex_SET(NativePointer, value);
		}

		public int Item
		{
			get => E_PROP_FHitResult_Item_GET(NativePointer);
			set => E_PROP_FHitResult_Item_SET(NativePointer, value);
		}

		public string MyBoneName
		{
			get => E_PROP_FHitResult_MyBoneName_GET(NativePointer);
			set => E_PROP_FHitResult_MyBoneName_SET(NativePointer, value);
		}

		public float PenetrationDepth
		{
			get => E_PROP_FHitResult_PenetrationDepth_GET(NativePointer);
			set => E_PROP_FHitResult_PenetrationDepth_SET(NativePointer, value);
		}

		public float Time
		{
			get => E_PROP_FHitResult_Time_GET(NativePointer);
			set => E_PROP_FHitResult_Time_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Utility to return the Actor that owns the Component that was hit. </para>
		/// </summary>
		public AActor GetActor()
			=> E_FHitResult_GetActor(this);
		
		
		/// <summary>
		/// <para>Utility to return the Component that was hit. </para>
		/// </summary>
		public UPrimitiveComponent GetComponent()
			=> E_FHitResult_GetComponent(this);
		
		
		/// <summary>
		/// <para>Static utility function that returns the first 'blocking' hit in an array of results. </para>
		/// </summary>
		public FHitResult GetFirstBlockingHit(TArray<FHitResult> inHits)
			=> E_FHitResult_GetFirstBlockingHit(this, inHits);
		
		
		/// <summary>
		/// <para>Static utility function that returns the number of blocking hits in array. </para>
		/// </summary>
		public int GetNumBlockingHits(TArray<FHitResult> inHits)
			=> E_FHitResult_GetNumBlockingHits(this, inHits);
		
		
		/// <summary>
		/// <para>Static utility function that returns the number of overlapping hits in array. </para>
		/// </summary>
		public int GetNumOverlapHits(TArray<FHitResult> inHits)
			=> E_FHitResult_GetNumOverlapHits(this, inHits);
		
		
		/// <summary>
		/// <para>Get a copy of the HitResult with relevant information reversed. </para>
		/// <para>For example when receiving a hit from another object, we reverse the normals. </para>
		/// </summary>
		public FHitResult GetReversedHit(FHitResult hit)
			=> E_FHitResult_GetReversedHit(this, hit);
		
		
		/// <summary>
		/// <para>Initialize empty hit result with given time. </para>
		/// </summary>
		public void Init()
			=> E_FHitResult_Init(this);
		
		
		/// <summary>
		/// <para>Initialize empty hit result with given time, TraceStart, and TraceEnd </para>
		/// </summary>
		public void Init(FVector start, FVector end)
			=> E_FHitResult_Init_o1(this, start, end);
		
		
		/// <summary>
		/// <para>Return true if there was a blocking hit that was not caused by starting in penetration. </para>
		/// </summary>
		public bool IsValidBlockingHit()
			=> E_FHitResult_IsValidBlockingHit(this);
		
		
		/// <summary>
		/// <para>Reset hit result while optionally saving TraceStart and TraceEnd. </para>
		/// </summary>
		public void Reset(float inTime, bool bPreserveTraceData = true)
			=> E_FHitResult_Reset(this, inTime, bPreserveTraceData);
		
		public override string ToString()
			=> E_FHitResult_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FHitResult self)
		{
			return self.NativePointer;
		}

		public static implicit operator FHitResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FHitResult(Adress, false);
		}}}
