// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:171

namespace UnrealEngine
{
	[ManageType("ManageStaticMeshComponent")]
	public partial class ManageStaticMeshComponent : UStaticMeshComponent
	{
		public ManageStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageStaticMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageStaticMeshComponent>(PtrDesc);
		}}}
