using RimWorld;
using Verse;
using Verse.AI;

namespace ExtraPsycasts
{
    public class CompAbilityEffect_ExtraPsycasts_ApplyMentalState : CompAbilityEffect
    {
        public new CompProperties_ExtraPsycasts_ApplyMentalState Props =>
            (CompProperties_ExtraPsycasts_ApplyMentalState) props;

        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            base.Apply(target, dest);

            if (target.Pawn == null)
            {
                return;
            }

            if (target.Pawn.InMentalState == false)
            {
                return;
            }

            target.Pawn.MentalState.RecoverFromState();
            target.Pawn.jobs.ClearQueuedJobs();
            target.Pawn.jobs.EndCurrentJob(JobCondition.InterruptForced);

            if (Props.mentalState == null)
            {
                return;
            }

            target.Pawn.mindState.mentalStateHandler.TryStartMentalState(Props.mentalState);
        }
    }
}