using UnrealBuildTool;

public class ReVolt_AlphaTarget : TargetRules
{
	public ReVolt_AlphaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ReVolt_Alpha");
	}
}
