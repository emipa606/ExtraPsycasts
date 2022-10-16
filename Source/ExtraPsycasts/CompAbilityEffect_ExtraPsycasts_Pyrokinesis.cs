using RimWorld;
using Verse;

namespace ExtraPsycasts;

public class CompAbilityEffect_ExtraPsycasts_Pyrokinesis : CompAbilityEffect
{
    public new CompProperties_ExtraPsycasts_Pyrokinesis Props => (CompProperties_ExtraPsycasts_Pyrokinesis)props;

    public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
    {
        base.Apply(target, dest);
        GenExplosion.DoExplosion(target.Cell, parent.pawn.MapHeld, Props.fireRadius, DamageDefOf.Flame, null, 0,
            -1f, SoundDefOf.Interact_Ignite, null, null, null, ThingDefOf.Fire, 1f);
    }

    public override void DrawEffectPreview(LocalTargetInfo target)
    {
        GenDraw.DrawRadiusRing(target.Cell, Props.fireRadius);
    }
}