using RimWorld;
using Verse;

namespace ExtraPsycasts
{
    public class CompAbilityEffect_ExtraPsycasts_ApplyThought : CompAbilityEffect
    {
        public new CompProperties_ExtraPsycasts_ApplyThought Props => (CompProperties_ExtraPsycasts_ApplyThought) props;

        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            base.Apply(target, dest);

            if (target.Pawn == null)
            {
                return;
            }

            target.Pawn.needs.mood.thoughts.memories.TryGainMemory(Props.thought);
        }
    }
}