// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:104

namespace UnrealEngine
{
	public  partial class FRendererStencilMaskEvaluation : NativeStructWrapper
	{
		internal FRendererStencilMaskEvaluation(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRendererStencilMaskEvaluation() :
			base(E_CreateStruct_FRendererStencilMaskEvaluation(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRendererStencilMaskEvaluation();
		
		#endregion
		
		public static implicit operator IntPtr(FRendererStencilMaskEvaluation self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRendererStencilMaskEvaluation(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRendererStencilMaskEvaluation(Adress, false);
		}}}
