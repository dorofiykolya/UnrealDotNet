// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

namespace UnrealEngine
{
	[ManageType("ManageSpringArmComponent")]
	public partial class ManageSpringArmComponent : USpringArmComponent
	{
		public ManageSpringArmComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Updates the desired arm location, calling BlendLocations to do the actual blending if a trace is done </para>
		/// </summary>
		protected override void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float deltaTime) { }
		
		public static implicit operator IntPtr(ManageSpringArmComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSpringArmComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpringArmComponent>(PtrDesc);
		}}}
