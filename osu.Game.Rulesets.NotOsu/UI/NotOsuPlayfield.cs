﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Game.Rulesets.UI;
using osuTK;

namespace osu.Game.Rulesets.NotOsu.UI
{
    [Cached]
    public partial class NotOsuPlayfield : Playfield
    {
        public static readonly Vector2 BASE_SIZE = new Vector2(512, 384);

        [BackgroundDependencyLoader]
        private void load()
        {
            AddRangeInternal([
                HitObjectContainer
            ]);
        }
    }
}
