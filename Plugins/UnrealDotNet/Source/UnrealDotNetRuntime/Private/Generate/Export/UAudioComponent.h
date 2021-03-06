#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/AudioComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

class E_PROTECTED_WRAP_UAudioComponent : protected UAudioComponent
{
public:
	void PlayInternal_WRAP(const float StartTime, const float FadeInDuration, const float FadeVolumeLevel)
	{
		PlayInternal(StartTime, FadeInDuration, FadeVolumeLevel);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UAudioComponent_ActiveCount_GET(UAudioComponent* Ptr) { return Ptr->ActiveCount; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_ActiveCount_SET(UAudioComponent* Ptr, int32 Value) { Ptr->ActiveCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AudioComponentUserID_GET(UAudioComponent* Ptr) { return ConvertToManage_StringWrapper(Ptr->AudioComponentUserID); }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AudioComponentUserID_SET(UAudioComponent* Ptr, char* Value) { Ptr->AudioComponentUserID = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachLocationRule_GET(UAudioComponent* Ptr) { return Ptr->AutoAttachLocationRule; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachLocationRule_SET(UAudioComponent* Ptr, EAttachmentRule Value) { Ptr->AutoAttachLocationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachRotationRule_GET(UAudioComponent* Ptr) { return Ptr->AutoAttachRotationRule; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachRotationRule_SET(UAudioComponent* Ptr, EAttachmentRule Value) { Ptr->AutoAttachRotationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachScaleRule_GET(UAudioComponent* Ptr) { return Ptr->AutoAttachScaleRule; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachScaleRule_SET(UAudioComponent* Ptr, EAttachmentRule Value) { Ptr->AutoAttachScaleRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachSocketName_GET(UAudioComponent* Ptr) { return ConvertToManage_StringWrapper(Ptr->AutoAttachSocketName); }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachSocketName_SET(UAudioComponent* Ptr, char* Value) { Ptr->AutoAttachSocketName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_GET(UAudioComponent* Ptr) { return Ptr->EnvelopeFollowerAttackTime; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_SET(UAudioComponent* Ptr, int32 Value) { Ptr->EnvelopeFollowerAttackTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_GET(UAudioComponent* Ptr) { return Ptr->EnvelopeFollowerReleaseTime; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_SET(UAudioComponent* Ptr, int32 Value) { Ptr->EnvelopeFollowerReleaseTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_LowPassFilterFrequency_GET(UAudioComponent* Ptr) { return Ptr->LowPassFilterFrequency; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_LowPassFilterFrequency_SET(UAudioComponent* Ptr, float Value) { Ptr->LowPassFilterFrequency = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_OcclusionCheckInterval_GET(UAudioComponent* Ptr) { return Ptr->OcclusionCheckInterval; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_OcclusionCheckInterval_SET(UAudioComponent* Ptr, float Value) { Ptr->OcclusionCheckInterval = Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_UAudioComponent_OnAudioFinished(UAudioComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnAudioFinished";
		wrapper->SourceObject = Obj;
		Obj->OnAudioFinished.AddDynamic(wrapper, &UManageEventSender::Wrapper_FOnAudioFinished);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UAudioComponent_OnAudioFinished(UAudioComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UAudioComponent_OnAudioMultiEnvelopeValue(UAudioComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnAudioMultiEnvelopeValue";
		wrapper->SourceObject = Obj;
		Obj->OnAudioMultiEnvelopeValue.AddDynamic(wrapper, &UManageEventSender::Wrapper_FOnAudioMultiEnvelopeValue);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UAudioComponent_OnAudioMultiEnvelopeValue(UAudioComponent* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_UAudioComponent_PitchModulationMax_GET(UAudioComponent* Ptr) { return Ptr->PitchModulationMax; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_PitchModulationMax_SET(UAudioComponent* Ptr, float Value) { Ptr->PitchModulationMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_PitchModulationMin_GET(UAudioComponent* Ptr) { return Ptr->PitchModulationMin; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_PitchModulationMin_SET(UAudioComponent* Ptr, float Value) { Ptr->PitchModulationMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_PitchMultiplier_GET(UAudioComponent* Ptr) { return Ptr->PitchMultiplier; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_PitchMultiplier_SET(UAudioComponent* Ptr, float Value) { Ptr->PitchMultiplier = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_Priority_GET(UAudioComponent* Ptr) { return Ptr->Priority; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_Priority_SET(UAudioComponent* Ptr, float Value) { Ptr->Priority = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_SubtitlePriority_GET(UAudioComponent* Ptr) { return Ptr->SubtitlePriority; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_SubtitlePriority_SET(UAudioComponent* Ptr, float Value) { Ptr->SubtitlePriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_VolumeModulationMax_GET(UAudioComponent* Ptr) { return Ptr->VolumeModulationMax; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_VolumeModulationMax_SET(UAudioComponent* Ptr, float Value) { Ptr->VolumeModulationMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_VolumeModulationMin_GET(UAudioComponent* Ptr) { return Ptr->VolumeModulationMin; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_VolumeModulationMin_SET(UAudioComponent* Ptr, float Value) { Ptr->VolumeModulationMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_VolumeMultiplier_GET(UAudioComponent* Ptr) { return Ptr->VolumeMultiplier; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_VolumeMultiplier_SET(UAudioComponent* Ptr, float Value) { Ptr->VolumeMultiplier = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAudioComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAudioComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UAudioComponent_AdjustVolume(UAudioComponent* Self, float AdjustVolumeDuration, float AdjustVolumeLevel)
	{
		auto _p0 = AdjustVolumeDuration;
		auto _p1 = AdjustVolumeLevel;
		Self->AdjustVolume(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_FadeIn(UAudioComponent* Self, float FadeInDuration, float FadeVolumeLevel, float StartTime)
	{
		auto _p0 = FadeInDuration;
		auto _p1 = FadeVolumeLevel;
		auto _p2 = StartTime;
		Self->FadeIn(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UAudioComponent_FadeOut(UAudioComponent* Self, float FadeOutDuration, float FadeVolumeLevel)
	{
		auto _p0 = FadeOutDuration;
		auto _p1 = FadeVolumeLevel;
		Self->FadeOut(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetAudioComponentUserID(UAudioComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetAudioComponentUserID());
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsPlaying(UAudioComponent* Self)
	{
		return Self->IsPlaying();
	}

	DOTNET_EXPORT auto E_UAudioComponent_Play(UAudioComponent* Self, float StartTime)
	{
		auto _p0 = StartTime;
		Self->Play(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_PlayInternal(UAudioComponent* Self, float StartTime, float FadeInDuration, float FadeVolumeLevel)
	{
		auto _p0 = StartTime;
		auto _p1 = FadeInDuration;
		auto _p2 = FadeVolumeLevel;
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->PlayInternal_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetBoolParameter(UAudioComponent* Self, char* InName, bool InBool)
	{
		auto _p0 = ConvertFromManage_FName(InName);
		auto _p1 = InBool;
		Self->SetBoolParameter(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetFloatParameter(UAudioComponent* Self, char* InName, float InFloat)
	{
		auto _p0 = ConvertFromManage_FName(InName);
		auto _p1 = InFloat;
		Self->SetFloatParameter(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetIntParameter(UAudioComponent* Self, char* InName, int32 InInt)
	{
		auto _p0 = ConvertFromManage_FName(InName);
		auto _p1 = InInt;
		Self->SetIntParameter(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetLowPassFilterEnabled(UAudioComponent* Self, bool InLowPassFilterEnabled)
	{
		auto _p0 = InLowPassFilterEnabled;
		Self->SetLowPassFilterEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetLowPassFilterFrequency(UAudioComponent* Self, float InLowPassFilterFrequency)
	{
		auto _p0 = InLowPassFilterFrequency;
		Self->SetLowPassFilterFrequency(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetPaused(UAudioComponent* Self, bool bPause)
	{
		auto _p0 = bPause;
		Self->SetPaused(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetPitchMultiplier(UAudioComponent* Self, float NewPitchMultiplier)
	{
		auto _p0 = NewPitchMultiplier;
		Self->SetPitchMultiplier(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetSoundParameter(UAudioComponent* Self, INT_PTR Param)
	{
		auto& _p0 = *(FAudioComponentParam*)Param;
		Self->SetSoundParameter(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetUISound(UAudioComponent* Self, bool bInUISound)
	{
		auto _p0 = bInUISound;
		Self->SetUISound(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetVolumeMultiplier(UAudioComponent* Self, float NewVolumeMultiplier)
	{
		auto _p0 = NewVolumeMultiplier;
		Self->SetVolumeMultiplier(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_Stop(UAudioComponent* Self)
	{
		Self->Stop();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
