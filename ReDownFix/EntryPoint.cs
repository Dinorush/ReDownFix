using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace ReDownFix
{
    [BepInPlugin("Dinorush." + MODNAME, MODNAME, "1.0.1")]
    internal sealed class EntryPoint : BasePlugin
    {
        public const string MODNAME = "ReDownFix";
        public override void Load()
        {
            new Harmony(MODNAME).PatchAll();
            Log.LogMessage("Loaded " + MODNAME);
        }
    }
}