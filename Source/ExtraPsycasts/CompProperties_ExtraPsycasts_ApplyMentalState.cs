using RimWorld;
using Verse;

namespace ExtraPsycasts;

public class CompProperties_ExtraPsycasts_ApplyMentalState : CompProperties_AbilityEffect
{
    public MentalStateDef mentalState;

    public CompProperties_ExtraPsycasts_ApplyMentalState()
    {
        compClass = typeof(CompAbilityEffect_ExtraPsycasts_ApplyMentalState);
    }
}