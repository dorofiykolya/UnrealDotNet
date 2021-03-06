#pragma once

// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/SkinnedMeshComponent.h"
#include "ManageSkinnedMeshComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSkinnedMeshComponent : public USkinnedMeshComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void ClearRefPoseOverride() override;
	virtual void SetRefPoseOverride(const TArray<FTransform>& NewRefPoseTransforms) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
