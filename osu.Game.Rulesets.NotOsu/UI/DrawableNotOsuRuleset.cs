// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.NotOsu.Objects;
using osu.Game.Rulesets.NotOsu.Objects.Drawables;
using osu.Game.Rulesets.NotOsu.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.NotOsu.UI
{
    [Cached]
    public partial class DrawableNotOsuRuleset : DrawableRuleset<NotOsuHitObject>
    {
        public DrawableNotOsuRuleset(NotOsuRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
        }

        protected override Playfield CreatePlayfield() => new NotOsuPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new NotOsuFramedReplayInputHandler(replay);

        public override DrawableHitObject<NotOsuHitObject> CreateDrawableRepresentation(NotOsuHitObject h) => new DrawableNotOsuHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new NotOsuInputManager(Ruleset?.RulesetInfo);
    }
}
