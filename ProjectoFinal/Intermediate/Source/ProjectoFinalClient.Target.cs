using UnrealBuildTool;

public class ProjectoFinalClientTarget : TargetRules
{
	public ProjectoFinalClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ProjectoFinal");
	}
}
