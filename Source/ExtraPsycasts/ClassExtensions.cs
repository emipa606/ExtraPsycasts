using RimWorld;

namespace ExtraPsycasts
{
    // Extends classes with new methods
    public static class ClassExtensions
    {
        // SkillRecord extension: Allow pawns to learn from another
        public static void LearnFromAnother(this SkillRecord skillRecord, float xp, bool direct = false)
        {
            // Exit if the pawn is incapable of learning this skill, or no experience is gained
            if (skillRecord.TotallyDisabled || xp <= 0)
            {
                return;
            }

            // Update the skill with the gained experience
            skillRecord.xpSinceLastLevel += xp;

            if (!direct)
            {
                skillRecord.xpSinceMidnight += xp;
            }

            // Trigger an update of the SkillRecord
            skillRecord.Learn(0, direct);
        }
    }
}