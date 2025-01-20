﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Bindables;
using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using osuTK;

namespace osu.Game.Rulesets.NotOsu.Objects;

public abstract class NotOsuHitObject : HitObject, IHasPosition
{
    public override Judgement CreateJudgement() => new Judgement();

    private HitObjectProperty<Vector2> position;

    public IBindable<Vector2> PositionBindable => position.Bindable;

    public Vector2 Position
    {
        get => position.Value;
        set => position.Value = value;
    }

    public float X
    {
        get => Position.X;
        set => Position = new Vector2(value, Y);
    }

    public float Y
    {
        get => Position.Y;
        set => Position = new Vector2(X, value);
    }
}
