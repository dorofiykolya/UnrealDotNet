#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"

class E_PROTECTED_WRAP_ACharacter : protected ACharacter
{
	public:
	bool DoJump_WRAP(bool bReplayingMoves)
	{
		return DoJump(bReplayingMoves);
	}

}
;

extern "C"
{
	DOTNET_EXPORT char* E_PROP_ACharacter_MeshComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ACharacter*)Ptr)->MeshComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
DOTNET_EXPORT void E_PROP_ACharacter_MeshComponentName_SET(INT_PTR Ptr, char* Value) { ((ACharacter*)Ptr)->MeshComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ACharacter_CharacterMovementComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ACharacter*)Ptr)->CharacterMovementComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
DOTNET_EXPORT void E_PROP_ACharacter_CharacterMovementComponentName_SET(INT_PTR Ptr, char* Value) { ((ACharacter*)Ptr)->CharacterMovementComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ACharacter_CapsuleComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ACharacter*)Ptr)->CapsuleComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
DOTNET_EXPORT void E_PROP_ACharacter_CapsuleComponentName_SET(INT_PTR Ptr, char* Value) { ((ACharacter*)Ptr)->CapsuleComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT float E_PROP_ACharacter_CrouchedEyeHeight_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->CrouchedEyeHeight; }
	DOTNET_EXPORT void E_PROP_ACharacter_CrouchedEyeHeight_SET(INT_PTR Ptr, float Value) { ((ACharacter*)Ptr)->CrouchedEyeHeight = Value; }
	
	DOTNET_EXPORT float E_PROP_ACharacter_JumpKeyHoldTime_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpKeyHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpKeyHoldTime_SET(INT_PTR Ptr, float Value) { ((ACharacter*)Ptr)->JumpKeyHoldTime = Value; }
	
	DOTNET_EXPORT float E_PROP_ACharacter_JumpMaxHoldTime_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpMaxHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxHoldTime_SET(INT_PTR Ptr, float Value) { ((ACharacter*)Ptr)->JumpMaxHoldTime = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ACharacter_JumpMaxCount_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpMaxCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxCount_SET(INT_PTR Ptr, int32 Value) { ((ACharacter*)Ptr)->JumpMaxCount = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ACharacter_JumpCurrentCount_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpCurrentCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpCurrentCount_SET(INT_PTR Ptr, int32 Value) { ((ACharacter*)Ptr)->JumpCurrentCount = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_ACharacter_RepRootMotion_GET(INT_PTR Ptr) { return (INT_PTR) new FRepRootMotionMontage(((ACharacter*)Ptr)->RepRootMotion); }
	DOTNET_EXPORT void E_PROP_ACharacter_RepRootMotion_SET(INT_PTR Ptr, INT_PTR Value) { ((ACharacter*)Ptr)->RepRootMotion = *(FRepRootMotionMontage*)Value; }
	
	DOTNET_EXPORT void E_ACharacter_SetBase(INT_PTR Self, UPrimitiveComponent* NewBase, char* BoneName, bool bNotifyActor)
	{
		auto _p0 = NewBase;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bNotifyActor;
		((ACharacter*)Self)->SetBase(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_CacheInitialMeshOffset(INT_PTR Self, INT_PTR MeshRelativeLocation, INT_PTR MeshRelativeRotation)
	{
		auto _p0 = *(FVector*)MeshRelativeLocation;
		auto _p1 = *(FRotator*)MeshRelativeRotation;
		((ACharacter*)Self)->CacheInitialMeshOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_ReplicatedBasedMovement(INT_PTR Self)
	{
		((ACharacter*)Self)->OnRep_ReplicatedBasedMovement();
	}

	DOTNET_EXPORT float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetReplicatedServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT void E_ACharacter_SaveRelativeBasedMovement(INT_PTR Self, INT_PTR NewRelativeLocation, INT_PTR NewRotation, bool bRelativeRotation)
	{
		auto _p0 = *(FVector*)NewRelativeLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bRelativeRotation;
		((ACharacter*)Self)->SaveRelativeBasedMovement(_p0, _p1, _p2);
	}

	DOTNET_EXPORT uint8 E_ACharacter_GetReplicatedMovementMode(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseTranslationOffset(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((ACharacter*)Self)->GetBaseTranslationOffset());
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseRotationOffset(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((ACharacter*)Self)->GetBaseRotationOffset());
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseRotationOffsetRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((ACharacter*)Self)->GetBaseRotationOffsetRotator());
	}

	DOTNET_EXPORT bool E_ACharacter_CanJump(INT_PTR Self)
	{
		return ((ACharacter*)Self)->CanJump();
	}

	DOTNET_EXPORT bool E_ACharacter_DoJump(INT_PTR Self, bool bReplayingMoves)
	{
		auto _p0 = bReplayingMoves;
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->DoJump_WRAP(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_LaunchCharacter(INT_PTR Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		((ACharacter*)Self)->LaunchCharacter(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_OnWalkingOffLedge(INT_PTR Self, INT_PTR PreviousFloorImpactNormal, INT_PTR PreviousFloorContactNormal, INT_PTR PreviousLocation, float TimeDelta)
	{
		auto _p0 = *(FVector*)PreviousFloorImpactNormal;
		auto _p1 = *(FVector*)PreviousFloorContactNormal;
		auto _p2 = *(FVector*)PreviousLocation;
		auto _p3 = TimeDelta;
		((ACharacter*)Self)->OnWalkingOffLedge(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_ACharacter_CanCrouch(INT_PTR Self)
	{
		return ((ACharacter*)Self)->CanCrouch();
	}

	DOTNET_EXPORT void E_ACharacter_OnEndCrouch(INT_PTR Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((ACharacter*)Self)->OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_K2_UpdateCustomMovement(INT_PTR Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((ACharacter*)Self)->K2_UpdateCustomMovement(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateFromCompressedFlags(INT_PTR Self, uint8 Flags)
	{
		auto _p0 = Flags;
		((ACharacter*)Self)->UpdateFromCompressedFlags(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_RootMotionDebugClientPrintOnScreen(INT_PTR Self, char* InString)
	{
		auto _p0 = FString(InString);
		((ACharacter*)Self)->RootMotionDebugClientPrintOnScreen(_p0);
	}

	DOTNET_EXPORT bool E_ACharacter_RestoreReplicatedMove(INT_PTR Self, INT_PTR RootMotionRepMove)
	{
		auto _p0 = *(FSimulatedRootMotionReplicatedMove*)RootMotionRepMove;
		return ((ACharacter*)Self)->RestoreReplicatedMove(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateSimulatedPosition(INT_PTR Self, INT_PTR Location, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)NewRotation;
		((ACharacter*)Self)->UpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnUpdateSimulatedPosition(INT_PTR Self, INT_PTR OldLocation, INT_PTR OldRotation)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FQuat*)OldRotation;
		((ACharacter*)Self)->OnUpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT UCapsuleComponent* E_ACharacter_GetCapsuleComponent(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetCapsuleComponent();
	}

}
