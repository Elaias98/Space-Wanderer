using UnrealBuildTool;

public class ProjectoFinalTarget : TargetRules
{
	public ProjectoFinalTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectoFinal");
	}
}
