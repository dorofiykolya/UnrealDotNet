#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "GameFramework/Pawn.h"

class E_PROTECTED_WRAP_APawn : protected APawn
{
public:
	void DestroyPlayerInputComponent_WRAP()
	{
		DestroyPlayerInputComponent();
	}

}
;

extern "C"
{
	DOTNET_EXPORT float E_PROP_APawn_AllowedYawError_GET(INT_PTR Ptr) { return ((APawn*)Ptr)->AllowedYawError; }
	DOTNET_EXPORT void E_PROP_APawn_AllowedYawError_SET(INT_PTR Ptr, float Value) { ((APawn*)Ptr)->AllowedYawError = Value; }
	
	DOTNET_EXPORT float E_PROP_APawn_BaseEyeHeight_GET(INT_PTR Ptr) { return ((APawn*)Ptr)->BaseEyeHeight; }
	DOTNET_EXPORT void E_PROP_APawn_BaseEyeHeight_SET(INT_PTR Ptr, float Value) { ((APawn*)Ptr)->BaseEyeHeight = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_APawn_RemoteViewPitch_GET(INT_PTR Ptr) { return ((APawn*)Ptr)->RemoteViewPitch; }
	DOTNET_EXPORT void E_PROP_APawn_RemoteViewPitch_SET(INT_PTR Ptr, uint8 Value) { ((APawn*)Ptr)->RemoteViewPitch = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_APawn_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		(Self)->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT void E_APawn_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		(Self)->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT void E_APawn_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		(Self)->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT void E_APawn_AddMovementInput(APawn* Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		(Self)->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_APawn_ClientSetRotation(APawn* Self, INT_PTR NewRotation)
	{
		auto _p0 = *(FRotator*)NewRotation;
		(Self)->ClientSetRotation(_p0);
	}

	DOTNET_EXPORT void E_APawn_DestroyPlayerInputComponent(APawn* Self)
	{
		((E_PROTECTED_WRAP_APawn*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT void E_APawn_DetachFromControllerPendingDestroy(APawn* Self)
	{
		(Self)->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT void E_APawn_FaceRotation(APawn* Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		(Self)->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetControlRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator((Self)->GetControlRotation());
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetGravityDirection(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->GetGravityDirection());
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetLastMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->GetLastMovementInputVector());
	}

	DOTNET_EXPORT ObjectPointerDescription E_APawn_GetMovementBaseActor(APawn* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return MakePrtDesc((Self)->GetMovementBaseActor(_p0));
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->GetMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_GetPendingMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->GetPendingMovementInputVector());
	}

	DOTNET_EXPORT bool E_APawn_InputEnabled(APawn* Self)
	{
		return (Self)->InputEnabled();
	}

	DOTNET_EXPORT void E_APawn_Internal_AddMovementInput(APawn* Self, INT_PTR WorldAccel, bool bForce)
	{
		auto _p0 = *(FVector*)WorldAccel;
		auto _p1 = bForce;
		(Self)->Internal_AddMovementInput(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_ConsumeMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->Internal_ConsumeMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_GetLastMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->Internal_GetLastMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_GetMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->Internal_GetMovementInputVector());
	}

	DOTNET_EXPORT INT_PTR E_APawn_Internal_GetPendingMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->Internal_GetPendingMovementInputVector());
	}

	DOTNET_EXPORT bool E_APawn_IsControlled(APawn* Self)
	{
		return (Self)->IsControlled();
	}

	DOTNET_EXPORT INT_PTR E_APawn_K2_GetMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector((Self)->K2_GetMovementInputVector());
	}

	DOTNET_EXPORT void E_APawn_LaunchPawn(APawn* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		(Self)->LaunchPawn(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_APawn_MoveIgnoreActorAdd(APawn* Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		(Self)->MoveIgnoreActorAdd(_p0);
	}

	DOTNET_EXPORT void E_APawn_MoveIgnoreActorRemove(APawn* Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		(Self)->MoveIgnoreActorRemove(_p0);
	}

	DOTNET_EXPORT void E_APawn_OnRep_Controller(APawn* Self)
	{
		(Self)->OnRep_Controller();
	}

	DOTNET_EXPORT void E_APawn_OnRep_PlayerState(APawn* Self)
	{
		(Self)->OnRep_PlayerState();
	}

	DOTNET_EXPORT void E_APawn_PawnClientRestart(APawn* Self)
	{
		(Self)->PawnClientRestart();
	}

	DOTNET_EXPORT void E_APawn_PawnMakeNoise(APawn* Self, float Loudness, INT_PTR NoiseLocation, bool bUseNoiseMakerLocation, AActor* NoiseMaker)
	{
		auto _p0 = Loudness;
		auto _p1 = *(FVector*)NoiseLocation;
		auto _p2 = bUseNoiseMakerLocation;
		auto _p3 = NoiseMaker;
		(Self)->PawnMakeNoise(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_APawn_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		(Self)->PawnStartFire(_p0);
	}

	DOTNET_EXPORT void E_APawn_RecalculateBaseEyeHeight(APawn* Self)
	{
		(Self)->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT void E_APawn_Restart(APawn* Self)
	{
		(Self)->Restart();
	}

	DOTNET_EXPORT void E_APawn_SetCanAffectNavigationGeneration(APawn* Self, bool bNewValue, bool bForceUpdate)
	{
		auto _p0 = bNewValue;
		auto _p1 = bForceUpdate;
		(Self)->SetCanAffectNavigationGeneration(_p0, _p1);
	}

	DOTNET_EXPORT void E_APawn_SetPlayerDefaults(APawn* Self)
	{
		(Self)->SetPlayerDefaults();
	}

	DOTNET_EXPORT void E_APawn_SetRemoteViewPitch(APawn* Self, float NewRemoteViewPitch)
	{
		auto _p0 = NewRemoteViewPitch;
		(Self)->SetRemoteViewPitch(_p0);
	}

	DOTNET_EXPORT void E_APawn_SpawnDefaultController(APawn* Self)
	{
		(Self)->SpawnDefaultController();
	}

	DOTNET_EXPORT void E_APawn_TurnOff(APawn* Self)
	{
		(Self)->TurnOff();
	}

	DOTNET_EXPORT void E_APawn_UnPossessed(APawn* Self)
	{
		(Self)->UnPossessed();
	}

	DOTNET_EXPORT void E_APawn_UpdateNavAgent(APawn* Self)
	{
		(Self)->UpdateNavAgent();
	}

	DOTNET_EXPORT void E_APawn_UpdateNavigationRelevance(APawn* Self)
	{
		(Self)->UpdateNavigationRelevance();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
