using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FScopedLevelCollectionContextSwitch : NativeStructWrapper
	{
		internal FScopedLevelCollectionContextSwitch(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public static implicit operator IntPtr(FScopedLevelCollectionContextSwitch Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScopedLevelCollectionContextSwitch(Adress, false);
		}}}
