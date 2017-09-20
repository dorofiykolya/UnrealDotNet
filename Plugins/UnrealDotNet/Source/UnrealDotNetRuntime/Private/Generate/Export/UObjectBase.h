#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "UObject/UObjectBase.h"

class E_PROTECTED_WRAP_UObjectBase : protected UObjectBase
{
public:
	void LowLevelRename_WRAP(FName NewName, UObject* NewOuter)
	{
		LowLevelRename(NewName, NewOuter);
	}

	void RegisterDependencies_WRAP()
	{
		RegisterDependencies();
	}

}
;

extern "C"
{
	DOTNET_EXPORT char* E_UObjectBase_GetFName(UObjectBase* Self, int& ResultStringLen)
	{
		auto _result = (Self)->GetFName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT ObjectPointerDescription E_UObjectBase_GetOuter(UObjectBase* Self)
	{
		return MakePrtDesc((Self)->GetOuter());
	}

	DOTNET_EXPORT bool E_UObjectBase_IsValidLowLevel(UObjectBase* Self)
	{
		return (Self)->IsValidLowLevel();
	}

	DOTNET_EXPORT bool E_UObjectBase_IsValidLowLevelFast(UObjectBase* Self, bool bRecursive)
	{
		auto _p0 = bRecursive;
		return (Self)->IsValidLowLevelFast(_p0);
	}

	DOTNET_EXPORT void E_UObjectBase_LowLevelRename(UObjectBase* Self, char* NewName, UObject* NewOuter)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(NewName));
		auto _p1 = NewOuter;
		((E_PROTECTED_WRAP_UObjectBase*)Self)->LowLevelRename_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT void E_UObjectBase_RegisterDependencies(UObjectBase* Self)
	{
		((E_PROTECTED_WRAP_UObjectBase*)Self)->RegisterDependencies_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
