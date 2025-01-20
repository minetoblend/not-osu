using osu.Game.Tests.Visual;

namespace osu.Game.Rulesets.NotOsu.Tests;

public partial class TestSceneNotOsuEditor : EditorTestScene
{
    protected override Ruleset CreateEditorRuleset() => new NotOsuRuleset();
}
