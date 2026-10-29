using HarmonyLib;
using RimWorld;
using Verse;

namespace ExtraPsycasts;

[HarmonyPatch(typeof(SkillRecord), nameof(SkillRecord.Learn))]
internal static class SkillRecord_Learn
{
    // Code postfix 
    public static void Postfix(SkillRecord __instance, float xp, Pawn ___pawn, bool direct = false)
    {
        // Exit if there is no gain in experience
        if (xp <= 0)
        {
            return;
        }

        // Get the pawn which is gaining experience


        foreach (var hediff in ___pawn.health.hediffSet.hediffs)
        {
            // Continue if the hediff does not have the right components
            var hediffCompLinkMindLink = hediff.TryGetComp<HediffComp_Link_MindLink>();
            var hediffCompMindLink = hediff.TryGetComp<HediffComp_MindLink>();
            if (hediffCompLinkMindLink == null || hediffCompMindLink == null)
            {
                continue;
            }

            if (hediffCompLinkMindLink.other is not Pawn otherPawn)
            {
                continue;
            }

            // Otherwise pass this experience to the SkillRecord's new 'learn from another' method
            otherPawn.skills.GetSkill(__instance.def)
                .LearnFromAnother(xp * hediffCompMindLink.Props.xpMultiplier, direct);

            // Create motes to signify the transfer of experience
            var mote = DefDatabase<ThingDef>.GetNamed("Mote_PsychicLinkPulse_MindLink");
            MoteMaker.MakeInteractionOverlay(mote, ___pawn, hediffCompLinkMindLink.other);

            break;
        }
    }
}