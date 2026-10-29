using System.Reflection;
using HarmonyLib;
using Verse;

namespace ExtraPsycasts;

// Execute Harmony patching
[StaticConstructorOnStartup]
public static class Main
{
    static Main()
    {
        new Harmony("io.github.chromiumboy.extrapsycasts").PatchAll(Assembly.GetExecutingAssembly());
    }
}