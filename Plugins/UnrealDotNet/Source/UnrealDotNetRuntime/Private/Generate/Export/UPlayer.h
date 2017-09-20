#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Engine/Player.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPlayer(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPlayer>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT char* E_UPlayer_ConsoleCommand(UPlayer* Self, char* Cmd, bool bWriteToLog, int& ResultStringLen)
	{
		auto _p0 = FString(Cmd);
		auto _p1 = bWriteToLog;
		auto _result = (Self)->ConsoleCommand(_p0, _p1);
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
