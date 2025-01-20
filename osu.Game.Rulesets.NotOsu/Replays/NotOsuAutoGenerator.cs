// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.NotOsu.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.NotOsu.Replays
{
    public class NotOsuAutoGenerator : AutoGenerator<NotOsuReplayFrame>
    {
        public new Beatmap<NotOsuHitObject> Beatmap => (Beatmap<NotOsuHitObject>)base.Beatmap;

        public NotOsuAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new NotOsuReplayFrame());

            foreach (NotOsuHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new NotOsuReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                    // todo: add required inputs and extra frames.
                });
            }
        }
    }
}
