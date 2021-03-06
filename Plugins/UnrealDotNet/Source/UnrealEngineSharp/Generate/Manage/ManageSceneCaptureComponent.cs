// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:60

namespace UnrealEngine
{
	[ManageType("ManageSceneCaptureComponent")]
	public partial class ManageSceneCaptureComponent : USceneCaptureComponent
	{
		public ManageSceneCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSceneCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneCaptureComponent>(PtrDesc);
		}}}
