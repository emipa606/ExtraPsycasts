using System.Reflection;
using HarmonyLib;
using Verse;

namespace ExtraPsycasts;

// Execute Harmony patching
[StaticConstructorOnStartup]
public class Main
{
    static Main()
    {
        var harmony = new Harmony("io.github.chromiumboy.extrapsycasts");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}