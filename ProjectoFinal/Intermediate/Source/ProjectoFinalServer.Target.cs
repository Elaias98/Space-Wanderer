using UnrealBuildTool;

public class ProjectoFinalServerTarget : TargetRules
{
	public ProjectoFinalServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ProjectoFinal");
	}
}
