using RimWorld;

namespace ExtraPsycasts;

// Pyrokinesis
public class CompProperties_ExtraPsycasts_Pyrokinesis : CompProperties_AbilityEffect
{
    public float fireRadius;

    public CompProperties_ExtraPsycasts_Pyrokinesis()
    {
        compClass = typeof(CompAbilityEffect_ExtraPsycasts_Pyrokinesis);
    }
}