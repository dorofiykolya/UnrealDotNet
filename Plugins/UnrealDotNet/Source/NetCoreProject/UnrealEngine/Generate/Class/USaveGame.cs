using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USaveGame : UObject
	{
		public USaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		public USaveGame(UObject Parent = null, string Name = "SaveGame")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USaveGame(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_USaveGame(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USaveGame Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USaveGame(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USaveGame ?? new USaveGame(Adress);
		}}}
