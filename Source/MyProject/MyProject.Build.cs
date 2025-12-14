// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyProject : ModuleRules
{
	public MyProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MyProject",
			"MyProject/Variant_Platforming",
			"MyProject/Variant_Platforming/Animation",
			"MyProject/Variant_Combat",
			"MyProject/Variant_Combat/AI",
			"MyProject/Variant_Combat/Animation",
			"MyProject/Variant_Combat/Gameplay",
			"MyProject/Variant_Combat/Interfaces",
			"MyProject/Variant_Combat/UI",
			"MyProject/Variant_SideScrolling",
			"MyProject/Variant_SideScrolling/AI",
			"MyProject/Variant_SideScrolling/Gameplay",
			"MyProject/Variant_SideScrolling/Interfaces",
			"MyProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
