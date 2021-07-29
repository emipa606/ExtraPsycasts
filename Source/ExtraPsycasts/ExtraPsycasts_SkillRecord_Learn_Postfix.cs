using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ExtraPsycasts
{
    [HarmonyPatch(typeof(SkillRecord), "Learn")]
    internal static class ExtraPsycasts_SkillRecord_Learn_Postfix
    {
        // Access 'pawn' which is a private field
        private static readonly FieldInfo pawnField = AccessTools.Field(typeof(SkillRecord), "pawn");

        // Code postfix 
        private static void Postfix(SkillRecord __instance, float xp, bool direct = false)
        {
            // Exit if there no gain in experience
            if (xp <= 0)
            {
                return;
            }

            // Get the pawn which is gaining experience

            // Loop over the pawn's hediffs
            if (pawnField.GetValue(__instance) is not Pawn pawn)
            {
                return;
            }

            foreach (var hediff in pawn.health.hediffSet.hediffs)
            {
                // Continue if the hediff does not have the right components
                var hediffComp_Link_MindLink = hediff.TryGetComp<HediffComp_Link_MindLink>();
                var hediffComp_MindLink = hediff.TryGetComp<HediffComp_MindLink>();
                if (hediffComp_Link_MindLink == null || hediffComp_MindLink == null)
                {
                    continue;
                }

                // Otherwise pass this experience to the SkillRecord's new 'learn from another' method
                hediffComp_Link_MindLink.other.skills.GetSkill(__instance.def)
                    .LearnFromAnother(xp * hediffComp_MindLink.Props.xpMultiplier, direct);

                // Create motes to signify the transfer of experience
                //Log.Message("setting pulse color");
                var mote = DefDatabase<ThingDef>.GetNamed("Mote_PsychicLinkPulse_MindLink");
                MoteMaker.MakeInteractionOverlay(mote, pawn, hediffComp_Link_MindLink.other);

                break;
            }
        }
    }
}