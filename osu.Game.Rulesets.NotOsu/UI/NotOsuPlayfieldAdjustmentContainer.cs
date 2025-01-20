using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Rulesets.UI;
using osuTK;

namespace osu.Game.Rulesets.NotOsu.UI;

public partial class NotOsuAdjustmentContainer : PlayfieldAdjustmentContainer
{
    protected override Container<Drawable> Content => content;
    private readonly ScalingContainer content;

    private const float playfield_size_adjust = 0.8f;

    public NotOsuAdjustmentContainer()
    {
        Anchor = Anchor.Centre;
        Origin = Anchor.Centre;

        // Calculated from osu!stable as 512 (default gamefield size) / 640 (default window size)
        Size = new Vector2(playfield_size_adjust);

        InternalChild = new Container
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            RelativeSizeAxes = Axes.Both,
            FillMode = FillMode.Fit,
            FillAspectRatio = 4f / 3,
            Child = content = new ScalingContainer { RelativeSizeAxes = Axes.Both }
        };
    }

    /// <summary>
    /// A <see cref="Container"/> which scales its content relative to a target width.
    /// </summary>
    private partial class ScalingContainer : Container
    {
        protected override void Update()
        {
            base.Update();

            Scale = new Vector2(Parent!.ChildSize.X / NotOsuPlayfield.BASE_SIZE.X);
            Size = Vector2.Divide(Vector2.One, Scale);
        }
    }
}
