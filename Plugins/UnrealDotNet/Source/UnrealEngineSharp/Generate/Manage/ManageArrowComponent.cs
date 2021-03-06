// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

namespace UnrealEngine
{
	[ManageType("ManageArrowComponent")]
	public partial class ManageArrowComponent : UArrowComponent
	{
		public ManageArrowComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageArrowComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageArrowComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageArrowComponent>(PtrDesc);
		}}}
