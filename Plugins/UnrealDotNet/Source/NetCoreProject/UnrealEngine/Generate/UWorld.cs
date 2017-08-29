using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// The World is the top level object representing a map or a sandbox in which Actors and Components will exist and be rendered.
	/// A World can be a single Persistent Level with an optional list of streaming levels that are loaded and unloaded via volumes and blueprint functions
	/// or it can be a collection of levels organized with a World Composition.
	/// In a standalone game, generally only a single World exists except during seamless area transitions when both a destination and current world exists.
	/// In the editor many Worlds exist: The level being edited, each PIE instance, each editor tool which has an interactive rendered viewport, and many more.
	/// </summary>
	public partial class UWorld : UObject
	{
		public UWorld(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bInTick_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bInTick_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bIsBuilt_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bIsBuilt_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bTickNewlySpawned_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bTickNewlySpawned_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bPostTickComponentUpdate_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bPostTickComponentUpdate_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_Struct_UWorld_PlayerNum_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_PlayerNum_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_TimeSinceLastPendingKillPurge_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_TimeSinceLastPendingKillPurge_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_FullPurgeTriggered_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_FullPurgeTriggered_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bShouldDelayGarbageCollect_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bShouldDelayGarbageCollect_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bIsWorldInitialized_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bIsWorldInitialized_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_Struct_UWorld_StreamingVolumeUpdateDelay_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_StreamingVolumeUpdateDelay_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bIsLevelStreamingFrozen_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bIsLevelStreamingFrozen_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bShouldForceUnloadStreamingLevels_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bShouldForceUnloadStreamingLevels_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bShouldForceVisibleStreamingLevels_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bShouldForceVisibleStreamingLevels_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bHack_Force_UsesGameHiddenFlags_True_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bHack_Force_UsesGameHiddenFlags_True_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bIsRunningConstructionScript_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bIsRunningConstructionScript_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bShouldSimulatePhysics_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bShouldSimulatePhysics_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bCreateRenderStateForHiddenComponents_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bCreateRenderStateForHiddenComponents_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_UWorld_bDebugDrawAllTraceTags_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_bDebugDrawAllTraceTags_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern double E_Struct_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(IntPtr Ptr, double Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_TimeSeconds_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_TimeSeconds_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_UnpausedTimeSeconds_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_UnpausedTimeSeconds_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_RealTimeSeconds_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_RealTimeSeconds_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_AudioTimeSeconds_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_AudioTimeSeconds_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_DeltaTimeSeconds_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_DeltaTimeSeconds_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_PauseDelay_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_PauseDelay_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_Struct_UWorld_OriginOffsetThisFrame_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_OriginOffsetThisFrame_SET(IntPtr Ptr, FVector Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_UWorld_NextSwitchCountdown_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_NextSwitchCountdown_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_Struct_UWorld_NumTextureStreamingUnbuiltComponents_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_NumTextureStreamingUnbuiltComponents_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_Struct_UWorld_NumTextureStreamingDirtyResources_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_UWorld_NumTextureStreamingDirtyResources_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_CreateFXSystem(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_SetShouldTick(IntPtr Self, bool bInShouldTick);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_ShouldTick(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_UWorld_GetNumPawns(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_UWorld_GetTimeSeconds(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_UWorld_TimeSince(IntPtr Self, float Time);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_AddPawn(IntPtr Self, APawn Pawn);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_AddNetworkActor(IntPtr Self, AActor Actor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_ContainsActor(IntPtr Self, AActor Actor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_AllowAudioPlayback(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_UpdateWorldComponents(IntPtr Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_CleanupWorld(IntPtr Self, bool bSessionEnded, bool bCleanupResources, UWorld NewWorld);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_DestroyWorld(IntPtr Self, bool bInformEngineOfWorld, UWorld NewWorld);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_SetTimeUntilNextGarbageCollection(IntPtr Self, float MinTimeUntilNextPass);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(IntPtr Self, UActorComponent Component, bool bForceGameThread);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_ClearActorComponentEndOfFrameUpdate(IntPtr Self, UActorComponent Component);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_UpdateActorComponentEndOfFrameUpdateState(IntPtr Self, UActorComponent Component);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_ProcessLevelStreamingVolumes(IntPtr Self, IntPtr OverrideViewLocation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_EditorDestroyActor(IntPtr Self, AActor Actor, bool bShouldModifyLevel);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_DestroyActor(IntPtr Self, AActor Actor, bool bNetForce, bool bShouldModifyLevel);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_RemoveActor(IntPtr Self, AActor Actor, bool bShouldModifyLevel);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_FindTeleportSpot(IntPtr Self, AActor TestActor, IntPtr PlaceLocation, IntPtr PlaceRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_EncroachingBlockingGeometry(IntPtr Self, AActor TestActor, IntPtr TestLocation, IntPtr TestRotation, IntPtr ProposedAdjustment);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_DelayStreamingVolumeUpdates(IntPtr Self, int InFrameDelay);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_TransferBlueprintDebugReferences(IntPtr Self, UWorld NewWorld);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_UWorld_GetProgressDenominator(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether we are in the middle of ticking actors/components or not
		/// </summary>
		public bool bInTick
		{
			get => E_Struct_UWorld_bInTick_GET(NativePointer);
			set => E_Struct_UWorld_bInTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we have already built the collision tree or not
		/// </summary>
		public bool bIsBuilt
		{
			get => E_Struct_UWorld_bIsBuilt_GET(NativePointer);
			set => E_Struct_UWorld_bIsBuilt_SET(NativePointer, value);
		}

		
		/// <summary>
		/// We are in the middle of actor ticking, so add tasks for newly spawned actors
		/// </summary>
		public bool bTickNewlySpawned
		{
			get => E_Struct_UWorld_bTickNewlySpawned_GET(NativePointer);
			set => E_Struct_UWorld_bTickNewlySpawned_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates that during world ticking we are doing the final component update of dirty components
		/// (after PostAsyncWork and effect physics scene has run.
		/// </summary>
		public bool bPostTickComponentUpdate
		{
			get => E_Struct_UWorld_bPostTickComponentUpdate_GET(NativePointer);
			set => E_Struct_UWorld_bPostTickComponentUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Counter for allocating game- unique controller player numbers
		/// </summary>
		public int PlayerNum
		{
			get => E_Struct_UWorld_PlayerNum_GET(NativePointer);
			set => E_Struct_UWorld_PlayerNum_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds (game time so we respect time dilation) since the last time we purged references to pending kill objects
		/// </summary>
		public float TimeSinceLastPendingKillPurge
		{
			get => E_Struct_UWorld_TimeSinceLastPendingKillPurge_GET(NativePointer);
			set => E_Struct_UWorld_TimeSinceLastPendingKillPurge_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether a full purge has been triggered, so that the next GarbageCollect will do a full purge no matter what.
		/// </summary>
		public bool FullPurgeTriggered
		{
			get => E_Struct_UWorld_FullPurgeTriggered_GET(NativePointer);
			set => E_Struct_UWorld_FullPurgeTriggered_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we should delay GC for one frame to finish some pending operation
		/// </summary>
		public bool bShouldDelayGarbageCollect
		{
			get => E_Struct_UWorld_bShouldDelayGarbageCollect_GET(NativePointer);
			set => E_Struct_UWorld_bShouldDelayGarbageCollect_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether world object has been initialized via Init()
		/// </summary>
		public bool bIsWorldInitialized
		{
			get => E_Struct_UWorld_bIsWorldInitialized_GET(NativePointer);
			set => E_Struct_UWorld_bIsWorldInitialized_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Number of frames to delay Streaming Volume updating, useful if you preload a bunch of levels but the camera hasn't caught up yet (INDEX_NONE for infinite)
		/// </summary>
		public int StreamingVolumeUpdateDelay
		{
			get => E_Struct_UWorld_StreamingVolumeUpdateDelay_GET(NativePointer);
			set => E_Struct_UWorld_StreamingVolumeUpdateDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is level streaming currently frozen?
		/// </summary>
		public bool bIsLevelStreamingFrozen
		{
			get => E_Struct_UWorld_bIsLevelStreamingFrozen_GET(NativePointer);
			set => E_Struct_UWorld_bIsLevelStreamingFrozen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is forcibly unloading streaming levels?
		/// </summary>
		public bool bShouldForceUnloadStreamingLevels
		{
			get => E_Struct_UWorld_bShouldForceUnloadStreamingLevels_GET(NativePointer);
			set => E_Struct_UWorld_bShouldForceUnloadStreamingLevels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is forcibly making streaming levels visible?
		/// </summary>
		public bool bShouldForceVisibleStreamingLevels
		{
			get => E_Struct_UWorld_bShouldForceVisibleStreamingLevels_GET(NativePointer);
			set => E_Struct_UWorld_bShouldForceVisibleStreamingLevels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True we want to execute a call to UpdateCulledTriggerVolumes during Tick
		/// </summary>
		public bool bDoDelayedUpdateCullDistanceVolumes
		{
			get => E_Struct_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(NativePointer);
			set => E_Struct_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Force UsesGameHiddenFlags to return true.
		/// </summary>
		public bool bHack_Force_UsesGameHiddenFlags_True
		{
			get => E_Struct_UWorld_bHack_Force_UsesGameHiddenFlags_True_GET(NativePointer);
			set => E_Struct_UWorld_bHack_Force_UsesGameHiddenFlags_True_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true this world is in the process of running the construction script for an actor
		/// </summary>
		public bool bIsRunningConstructionScript
		{
			get => E_Struct_UWorld_bIsRunningConstructionScript_GET(NativePointer);
			set => E_Struct_UWorld_bIsRunningConstructionScript_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true this world will tick physics to simulate. This isn't same as having Physics Scene.
		/// You need Physics Scene if you'd like to trace. This flag changed ticking
		/// </summary>
		public bool bShouldSimulatePhysics
		{
			get => E_Struct_UWorld_bShouldSimulatePhysics_GET(NativePointer);
			set => E_Struct_UWorld_bShouldSimulatePhysics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If TRUE, 'hidden' components will still create render proxy, so can draw info (see USceneComponent::ShouldRender)
		/// </summary>
		public bool bCreateRenderStateForHiddenComponents
		{
			get => E_Struct_UWorld_bCreateRenderStateForHiddenComponents_GET(NativePointer);
			set => E_Struct_UWorld_bCreateRenderStateForHiddenComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When set to true, all scene queries will be drawn
		/// </summary>
		public bool bDebugDrawAllTraceTags
		{
			get => E_Struct_UWorld_bDebugDrawAllTraceTags_GET(NativePointer);
			set => E_Struct_UWorld_bDebugDrawAllTraceTags_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in FPlatformTime::Seconds unbuilt time was last encountered. 0 means not yet.
		/// </summary>
		public double LastTimeUnbuiltLightingWasEncountered
		{
			get => E_Struct_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(NativePointer);
			set => E_Struct_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS paused when the game is paused, and IS dilated/clamped.
		/// </summary>
		public float TimeSeconds
		{
			get => E_Struct_UWorld_TimeSeconds_GET(NativePointer);
			set => E_Struct_UWorld_TimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS NOT paused when the game is paused, and IS dilated/clamped.
		/// </summary>
		public float UnpausedTimeSeconds
		{
			get => E_Struct_UWorld_UnpausedTimeSeconds_GET(NativePointer);
			set => E_Struct_UWorld_UnpausedTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS NOT paused when the game is paused, and IS NOT dilated/clamped.
		/// </summary>
		public float RealTimeSeconds
		{
			get => E_Struct_UWorld_RealTimeSeconds_GET(NativePointer);
			set => E_Struct_UWorld_RealTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS paused when the game is paused, and IS NOT dilated/clamped.
		/// </summary>
		public float AudioTimeSeconds
		{
			get => E_Struct_UWorld_AudioTimeSeconds_GET(NativePointer);
			set => E_Struct_UWorld_AudioTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Frame delta time in seconds adjusted by e.g. time dilation.
		/// </summary>
		public float DeltaTimeSeconds
		{
			get => E_Struct_UWorld_DeltaTimeSeconds_GET(NativePointer);
			set => E_Struct_UWorld_DeltaTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// time at which to start pause
		/// </summary>
		public float PauseDelay
		{
			get => E_Struct_UWorld_PauseDelay_GET(NativePointer);
			set => E_Struct_UWorld_PauseDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// World origin offset value. Non-zero only for a single frame when origin is rebased
		/// </summary>
		public FVector OriginOffsetThisFrame
		{
			get => E_Struct_UWorld_OriginOffsetThisFrame_GET(NativePointer);
			set => E_Struct_UWorld_OriginOffsetThisFrame_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Amount of time to wait before traveling to next map, gives clients time to receive final RPCs @see ServerTravelPause
		/// </summary>
		public float NextSwitchCountdown
		{
			get => E_Struct_UWorld_NextSwitchCountdown_GET(NativePointer);
			set => E_Struct_UWorld_NextSwitchCountdown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Num of components missing valid texture streaming data. Updated in map check.
		/// </summary>
		public int NumTextureStreamingUnbuiltComponents
		{
			get => E_Struct_UWorld_NumTextureStreamingUnbuiltComponents_GET(NativePointer);
			set => E_Struct_UWorld_NumTextureStreamingUnbuiltComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Num of resources that have changed since the last texture streaming build. Updated in map check.
		/// </summary>
		public int NumTextureStreamingDirtyResources
		{
			get => E_Struct_UWorld_NumTextureStreamingDirtyResources_GET(NativePointer);
			set => E_Struct_UWorld_NumTextureStreamingDirtyResources_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Creates a new FX system for this world
		/// </summary>
		public void CreateFXSystem()
			=> E_UWorld_CreateFXSystem(NativePointer);
		
		
		/// <summary>
		/// Sets whether or not this world is ticked by the engine, but use it at your own risk! This could
		/// have unintended consequences if used carelessly. That said, for worlds that are not interactive
		/// and not rendering, it can save the cost of ticking them. This should probably never be used
		/// for a primary game world.
		/// </summary>
		public void SetShouldTick(bool bInShouldTick)
			=> E_UWorld_SetShouldTick(NativePointer, bInShouldTick);
		
		
		/// <summary>
		/// Returns whether or not this world is currently ticking. See SetShouldTick.
		/// </summary>
		public bool ShouldTick()
			=> E_UWorld_ShouldTick(NativePointer);
		
		
		/// <summary>
		/// @return Returns the number of Pawns.
		/// </summary>
		public int GetNumPawns()
			=> E_UWorld_GetNumPawns(NativePointer);
		
		
		/// <summary>
		/// Returns time in seconds since world was brought up for play, IS stopped when game pauses, IS dilated/clamped
		/// @return time in seconds since world was brought up for play
		/// </summary>
		public float GetTimeSeconds()
			=> E_UWorld_GetTimeSeconds(NativePointer);
		
		
		/// <summary>
		/// Helper for getting the time since a certain time.
		/// </summary>
		public float TimeSince(float Time)
			=> E_UWorld_TimeSince(NativePointer, Time);
		
		
		/// <summary>
		/// Inserts the passed in pawn at the front of the linked list of pawns.
		/// @param	Pawn	Pawn to insert, use NULL to clear list
		/// </summary>
		public void AddPawn(APawn Pawn)
			=> E_UWorld_AddPawn(NativePointer, Pawn);
		
		
		/// <summary>
		/// Adds the passed in actor to the special network actor list
		/// This list is used to specifically single out actors that are relevant for networking without having to scan the much large list
		/// @param	Actor	Actor to add
		/// </summary>
		public void AddNetworkActor(AActor Actor)
			=> E_UWorld_AddNetworkActor(NativePointer, Actor);
		
		
		/// <summary>
		/// Returns whether the passed in actor is part of any of the loaded levels actors array.
		/// Warning: Will return true for pending kill actors!
		/// @param	Actor	Actor to check whether it is contained by any level
		/// @return	true if actor is contained by any of the loaded levels, false otherwise
		/// </summary>
		public bool ContainsActor(AActor Actor)
			=> E_UWorld_ContainsActor(NativePointer, Actor);
		
		
		/// <summary>
		/// Returns whether audio playback is allowed for this scene.
		/// @return true if current world is GWorld, false otherwise
		/// </summary>
		public bool AllowAudioPlayback()
			=> E_UWorld_AllowAudioPlayback(NativePointer);
		
		
		/// <summary>
		/// Updates world components like e.g. line batcher and all level components.
		/// @param	bRerunConstructionScripts	If we should rerun construction scripts on actors
		/// @param	bCurrentLevelOnly			If true, affect only the current level.
		/// </summary>
		public void UpdateWorldComponents(bool bRerunConstructionScripts, bool bCurrentLevelOnly)
			=> E_UWorld_UpdateWorldComponents(NativePointer, bRerunConstructionScripts, bCurrentLevelOnly);
		
		
		/// <summary>
		/// Cleans up components, streaming data and assorted other intermediate data.
		/// @param bSessionEnded whether to notify the viewport that the game session has ended
		/// @param NewWorld Optional new world that will be loaded after this world is cleaned up. Specify a new world to prevent it and it's sublevels from being GCed during map transitions.
		/// </summary>
		public void CleanupWorld(bool bSessionEnded = true, bool bCleanupResources = true, UWorld NewWorld = null)
			=> E_UWorld_CleanupWorld(NativePointer, bSessionEnded, bCleanupResources, NewWorld);
		
		
		/// <summary>
		/// Destroy this World instance. If destroying the world to load a different world, supply it here to prevent GC of the new world or it's sublevels.
		/// </summary>
		public void DestroyWorld(bool bInformEngineOfWorld, UWorld NewWorld = null)
			=> E_UWorld_DestroyWorld(NativePointer, bInformEngineOfWorld, NewWorld);
		
		
		/// <summary>
		/// Updates the timer (as a one-off) that is used to trigger garbage collection; this should only be used for things
		/// like performance tests, using it recklessly can dramatically increase memory usage and cost of the eventual GC.
		/// Note: Things that force a GC will still force a GC after using this method (and they will also reset the timer)
		/// </summary>
		public void SetTimeUntilNextGarbageCollection(float MinTimeUntilNextPass)
			=> E_UWorld_SetTimeUntilNextGarbageCollection(NativePointer, MinTimeUntilNextPass);
		
		
		/// <summary>
		/// Mark a component as needing an end of frame update
		/// @param Component - Component to update at the end of the frame
		/// @param bForceGameThread - if true, force this to happen on the game thread
		/// </summary>
		public void MarkActorComponentForNeededEndOfFrameUpdate(UActorComponent Component, bool bForceGameThread)
			=> E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(NativePointer, Component, bForceGameThread);
		
		
		/// <summary>
		/// Clears the need for a component to have a end of frame update
		/// @param Component - Component to update at the end of the frame
		/// </summary>
		public void ClearActorComponentEndOfFrameUpdate(UActorComponent Component)
			=> E_UWorld_ClearActorComponentEndOfFrameUpdate(NativePointer, Component);
		
		
		/// <summary>
		/// Updates an ActorComponent's cached state of whether it has been marked for end of frame update based on the current
		/// state of the World's NeedsEndOfFrameUpdate arrays
		/// @param Component - Component to update the cached state of
		/// </summary>
		public void UpdateActorComponentEndOfFrameUpdateState(UActorComponent Component)
			=> E_UWorld_UpdateActorComponentEndOfFrameUpdateState(NativePointer, Component);
		
		
		/// <summary>
		/// Issues level streaming load/unload requests based on whether
		/// local players are inside/outside level streaming volumes.
		/// @param OverrideViewLocation Optional position used to override the location used to calculate current streaming volumes
		/// </summary>
		public void ProcessLevelStreamingVolumes(FVector OverrideViewLocation = null)
			=> E_UWorld_ProcessLevelStreamingVolumes(NativePointer, OverrideViewLocation);
		
		
		/// <summary>
		/// Wrapper for DestroyActor() that should be called in the editor.
		/// @param	bShouldModifyLevel		If true, Modify() the level before removing the actor.
		/// </summary>
		public bool EditorDestroyActor(AActor Actor, bool bShouldModifyLevel)
			=> E_UWorld_EditorDestroyActor(NativePointer, Actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// Removes the actor from its level's actor list and generally cleans up the engine's internal state.
		/// What this function does not do, but is handled via garbage collection instead, is remove references
		/// to this actor from all other actors, and kill the actor's resources.  This function is set up so that
		/// no problems occur even if the actor is being destroyed inside its recursion stack.
		/// @param	ThisActor				Actor to remove.
		/// @param	bNetForce				[opt] Ignored unless called during play.  Default is false.
		/// @param	bShouldModifyLevel		[opt] If true, Modify() the level before removing the actor.  Default is true.
		/// @return							true if destroyed or already marked for destruction, false if actor couldn't be destroyed.
		/// </summary>
		public bool DestroyActor(AActor Actor, bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_UWorld_DestroyActor(NativePointer, Actor, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// Removes the passed in actor from the actor lists. Please note that the code actually doesn't physically remove the
		/// index but rather clears it so other indices are still valid and the actors array size doesn't change.
		/// @param	Actor					Actor to remove.
		/// @param	bShouldModifyLevel		If true, Modify() the level before removing the actor if in the editor.
		/// </summary>
		public void RemoveActor(AActor Actor, bool bShouldModifyLevel)
			=> E_UWorld_RemoveActor(NativePointer, Actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// Try to find an acceptable position to place TestActor as close to possible to PlaceLocation.  Expects PlaceLocation to be a valid location inside the level.
		/// </summary>
		public bool FindTeleportSpot(AActor TestActor, FVector PlaceLocation, FRotator PlaceRotation)
			=> E_UWorld_FindTeleportSpot(NativePointer, TestActor, PlaceLocation, PlaceRotation);
		
		
		/// <summary>
		/// @Return true if Actor would encroach at TestLocation on something that blocks it.  Returns a ProposedAdjustment that might result in an unblocked TestLocation.
		/// </summary>
		public bool EncroachingBlockingGeometry(AActor TestActor, FVector TestLocation, FRotator TestRotation, FVector ProposedAdjustment = null)
			=> E_UWorld_EncroachingBlockingGeometry(NativePointer, TestActor, TestLocation, TestRotation, ProposedAdjustment);
		
		
		/// <summary>
		/// Sets the number of frames to delay Streaming Volume updating,
		/// useful if you preload a bunch of levels but the camera hasn't caught up yet
		/// </summary>
		public void DelayStreamingVolumeUpdates(int InFrameDelay)
			=> E_UWorld_DelayStreamingVolumeUpdates(NativePointer, InFrameDelay);
		
		
		/// <summary>
		/// Transfers the set of Kismet / Blueprint objects being debugged to the new world that are not already present, and updates blueprints accordingly
		/// @param	NewWorld	The new world to find equivalent objects in
		/// </summary>
		public void TransferBlueprintDebugReferences(UWorld NewWorld)
			=> E_UWorld_TransferBlueprintDebugReferences(NativePointer, NewWorld);
		
		
		/// <summary>
		/// Returns the actor count.
		/// </summary>
		public int GetProgressDenominator()
			=> E_UWorld_GetProgressDenominator(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(UWorld Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UWorld(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UWorld(Adress);
		}