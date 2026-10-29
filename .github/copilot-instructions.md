# GitHub Copilot Instructions for Extra Psycasts (Continued) Mod

## Mod Overview and Purpose

Extra Psycasts (Continued) is an update to the Chromiumboys mod, which adds a collection of 11 new psycasts to the Rimworld Royalty Expansion. These abilities can be granted by upgrading a psychic amplifier and obtaining the appropriate psytrainer through quest rewards or trading. The mod requires the Royalty Expansion for Rimworld.

## Key Features and Systems

- **Non-aggressive psycasts**: These can be cast by undrafted pawns and those incapable of violence.
- **New psycasts**:
  - **Accelerate healing**: Increases healing rate and infection immunity.
  - **Pyrokinesis**: Starts a small fire at a target location without requiring line of sight.
  - **Precognition**: Improves combat accuracy and melee dodge chance.
  - **Soothe mind**: Provides positive moodlet and snaps the target out of mental breaks.
  - **Fortitude**: Reduces damage received.
  - **Stasis**: Puts a friendly target into a coma-like state, slowing needs depletion and bleeding.
  - **Telepathic link**: Shares experience between the psycaster and a friendly target.
  - **Cognitive enhancement**: Increases research speed for a friendly target.
  - **Energise**: Increases movement speed and manual labor rate for a friendly target.
  - **Sense thoughts**: Improves social encounters and bartering performance.
  - **Psychic lance**: Deals brain damage to targets.

## Coding Patterns and Conventions

- **ClassExtensions.cs**: Contains methods for extending existing classes.
- **CompProperties_ExtraPsycasts_Pyrokinesis.cs**: Defines properties for the Pyrokinesis comp.
- **HediffComp_Link_MindLink.cs**: Handles the CompPostTick method for the mind link hediff.
- **HediffComp_MindLink.cs**: Defines properties for the mind link hediff.
- **HediffCompProperties_MindLink.cs**: Defines properties for the mind link hediff.

## XML Integration

- **DamagesDefs.xml**: Contains damage definitions.
- **ExtraPsycastDefs.xml**: Contains ability, damage, and hediff definitions.
- **HediffDefs.xml**: Contains hediff definitions.
- **Mote_Visual.xml**: Contains visual mote definitions.
- **ThoughtDefs.xml**: Contains thought definitions.

## Harmony Patching

Harmony patching is used to modify or extend existing RimWorld functionality. Ensure that any patches are well-documented and tested to avoid conflicts with other mods.

## Suggestions for Copilot

- Use Copilot to generate XML definitions for new psycasts, ensuring they adhere to the existing pattern in `ExtraPsycastDefs.xml`.
- Use Copilot to extend existing classes or create new ones, following the patterns in `ClassExtensions.cs`.
- Use Copilot to create or modify Harmony patches, ensuring they are well-documented and tested.
- Use Copilot to generate hediff comp properties and comps, following the patterns in `HediffCompProperties_MindLink.cs` and `HediffComp_Link_MindLink.cs`.
- Use Copilot to generate thought definitions, following the pattern in `ThoughtDefs.xml`.

By following these guidelines, you can leverage Copilot to efficiently develop and maintain the Extra Psycasts (Continued) mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

