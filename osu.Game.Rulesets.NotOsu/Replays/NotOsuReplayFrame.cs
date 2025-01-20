﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;
using osuTK;

namespace osu.Game.Rulesets.NotOsu.Replays
{
    public class NotOsuReplayFrame : ReplayFrame
    {
        public List<NotOsuAction> Actions = new List<NotOsuAction>();
        public Vector2 Position;

        public NotOsuReplayFrame(NotOsuAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
