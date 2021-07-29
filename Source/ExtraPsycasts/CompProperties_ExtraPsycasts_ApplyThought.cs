using RimWorld;

namespace ExtraPsycasts
{
    public class CompProperties_ExtraPsycasts_ApplyThought : CompProperties_AbilityEffect
    {
        public ThoughtDef thought;

        public CompProperties_ExtraPsycasts_ApplyThought()
        {
            compClass = typeof(CompAbilityEffect_ExtraPsycasts_ApplyThought);
        }
    }
}