#pragma once

// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Engine/Player.h"
#include "ManagePlayer.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePlayer : public UPlayer, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
