using HarmonyLib;
using RimWorld;
using Verse;

namespace ExtraPsycasts;

[HarmonyPatch(typeof(SkillRecord), "Learn")]
internal static class ExtraPsycasts_SkillRecord_Learn_Postfix
{
    // Code postfix 
    private static void Postfix(SkillRecord __instance, float xp, Pawn ___pawn, bool direct = false)
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
            var hediffComp_Link_MindLink = hediff.TryGetComp<HediffComp_Link_MindLink>();
            var hediffComp_MindLink = hediff.TryGetComp<HediffComp_MindLink>();
            if (hediffComp_Link_MindLink == null || hediffComp_MindLink == null)
            {
                continue;
            }

            if (hediffComp_Link_MindLink.other is not Pawn otherPawn)
            {
                continue;
            }

            // Otherwise pass this experience to the SkillRecord's new 'learn from another' method
            otherPawn.skills.GetSkill(__instance.def)
                .LearnFromAnother(xp * hediffComp_MindLink.Props.xpMultiplier, direct);

            // Create motes to signify the transfer of experience
            //Log.Message("setting pulse color");
            var mote = DefDatabase<ThingDef>.GetNamed("Mote_PsychicLinkPulse_MindLink");
            MoteMaker.MakeInteractionOverlay(mote, ___pawn, hediffComp_Link_MindLink.other);

            break;
        }
    }
}