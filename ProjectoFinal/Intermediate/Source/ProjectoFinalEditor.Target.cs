using UnrealBuildTool;

public class ProjectoFinalEditorTarget : TargetRules
{
	public ProjectoFinalEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProjectoFinal");
	}
}
