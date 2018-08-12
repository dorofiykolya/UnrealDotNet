#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/RectLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\RectLightComponent.h:18

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_URectLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<URectLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS