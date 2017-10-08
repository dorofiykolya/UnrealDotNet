using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLensBloomSettings : NativeStructWrapper
	{
		internal FLensBloomSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLensBloomSettings() :
			base(E_CreateStruct_FLensBloomSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensBloomSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensBloomSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FLensBloomSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensBloomSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensBloomSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensBloomSettings(Adress, false);
		}}}
