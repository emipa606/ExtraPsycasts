using RimWorld;
using Verse;

namespace ExtraPsycasts;

public class CompProperties_ExtraPsycasts_PsyLance : CompProperties_AbilityEffect
{
    public IntRange damageAmount = IntRange.zero;
    public DamageDef damageDef;

    public CompProperties_ExtraPsycasts_PsyLance()
    {
        compClass = typeof(CompAbilityEffect_ExtraPsycasts_PsyLance);
    }
}