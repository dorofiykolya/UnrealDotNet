using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPointLightComponent : ULightComponent
	{
		public UPointLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPointLightComponent(UObject Parent = null, string Name = "PointLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPointLightComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UPointLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPointLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPointLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPointLightComponent ?? new UPointLightComponent(Adress);
		}}}
