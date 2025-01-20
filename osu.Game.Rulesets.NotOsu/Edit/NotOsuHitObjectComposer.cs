using System;
using System.Collections.Generic;
using osu.Game.Rulesets.Edit;
using osu.Game.Rulesets.Edit.Tools;
using osu.Game.Rulesets.NotOsu.Objects;

namespace osu.Game.Rulesets.NotOsu.Edit;

public partial class NotOsuHitObjectComposer : HitObjectComposer<NotOsuHitObject>
{
    public NotOsuHitObjectComposer(Ruleset ruleset)
        : base(ruleset)
    {
    }

    protected override IReadOnlyList<CompositionTool> CompositionTools => Array.Empty<CompositionTool>();
}
