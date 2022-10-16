using Verse;

namespace ExtraPsycasts;

public class HediffCompProperties_MindLink : HediffCompProperties
{
    public float xpMultiplier = 1;

    public HediffCompProperties_MindLink()
    {
        compClass = typeof(HediffComp_MindLink);
    }
}