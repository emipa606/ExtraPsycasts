using RimWorld;
using Verse;

namespace ExtraPsycasts;

public class HediffComp_Link_MindLink : HediffComp_Link
{
    private MoteDualAttached mote;

    public override void CompPostTick(ref float severityAdjustment)
    {
        base.CompPostTick(ref severityAdjustment);
        if (!drawConnection)
        {
            return;
        }

        if (mote == null || mote.def.defName != "Mote_PsychicLinkLine_MindLink")
        {
            //Log.Message("setting link color");
            mote?.DeSpawn();

            var linkMote = DefDatabase<ThingDef>.GetNamed("Mote_PsychicLinkLine_MindLink");
            mote = MoteMaker.MakeInteractionOverlay(linkMote, parent.pawn, other);
        }

        mote.Maintain();
    }
}