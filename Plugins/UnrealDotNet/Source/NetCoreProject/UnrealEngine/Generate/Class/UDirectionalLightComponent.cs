using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDirectionalLightComponent : ULightComponent
	{
		public UDirectionalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDirectionalLightComponent(UObject Parent = null, string Name = "DirectionalLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDirectionalLightComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UDirectionalLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UDirectionalLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDirectionalLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDirectionalLightComponent ?? new UDirectionalLightComponent(Adress);
		}}}
