// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

namespace UnrealEngine
{
	public  partial class UPawnNoiseEmitterComponent : UActorComponent
	{
		public UPawnNoiseEmitterComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPawnNoiseEmitterComponent(UObject Parent = null, string Name = "PawnNoiseEmitterComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnNoiseEmitterComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnNoiseEmitterComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseTime(IntPtr self, bool bSourceWithinNoiseEmitter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(IntPtr self, bool bSourceWithinNoiseEmitter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnNoiseEmitterComponent_MakeNoise(IntPtr self, IntPtr noiseMaker, float loudness, IntPtr noiseLocation);
		
		#endregion
		
		#region Property
		public FVector LastRemoteNoisePosition
		{
			get => E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(NativePointer);
			set => E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(NativePointer, value);
		}

		public float NoiseLifetime
		{
			get => E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(NativePointer);
			set => E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetLastNoiseTime(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseTime(this, bSourceWithinNoiseEmitter);
		
		public float GetLastNoiseVolume(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(this, bSourceWithinNoiseEmitter);
		
		
		/// <summary>
		/// <para>Cache noises instigated by the owning pawn for AI sensing </para>
		/// <param name="NoiseMaker">is the actual actor which made the noise </param>
		/// <param name="Loudness">is the relative loudness of the noise (0.0 to 1.0) </param>
		/// <param name="NoiseLocation">is the position of the noise </param>
		/// </summary>
		public virtual void MakeNoise(AActor noiseMaker, float loudness, FVector noiseLocation)
			=> E_UPawnNoiseEmitterComponent_MakeNoise(this, noiseMaker, loudness, noiseLocation);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnNoiseEmitterComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPawnNoiseEmitterComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnNoiseEmitterComponent>(PtrDesc);
		}}}
