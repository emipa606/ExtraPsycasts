using RimWorld;
using Verse;

namespace ExtraPsycasts
{
    public class CompAbilityEffect_ExtraPsycasts_PsyLance : CompAbilityEffect
    {
        public new CompProperties_ExtraPsycasts_PsyLance Props => (CompProperties_ExtraPsycasts_PsyLance) props;

        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            base.Apply(target, dest);

            if (target.Pawn == null)
            {
                return;
            }

            var brain = target.Pawn.health.hediffSet.GetBrain();
            if (brain == null)
            {
                return;
            }

            var randomInRange = Props.damageAmount.RandomInRange;
            var damageInfo = new DamageInfo(Props.damageDef, randomInRange, 0f, -1f, null, brain);
            damageInfo.SetIgnoreArmor(true);

            target.Pawn.TakeDamage(damageInfo);
        }
    }
}