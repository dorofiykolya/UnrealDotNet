using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDrawFrustumComponent : UPrimitiveComponent
	{
		public UDrawFrustumComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDrawFrustumComponent(UObject Parent = null, string Name = "DrawFrustumComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDrawFrustumComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UDrawFrustumComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UDrawFrustumComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawFrustumComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDrawFrustumComponent ?? new UDrawFrustumComponent(Adress);
		}}}
