using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using ModBase.Utils;

namespace ModBase
{
    [BepInPlugin("Dinorush." + MODNAME, MODNAME, "1.0.0")]
    [BepInDependency(CC_MODNAME, BepInDependency.DependencyFlags.SoftDependency)]
    internal sealed class EntryPoint : BasePlugin
    {
        public const string MODNAME = "ReDownFix";
        private const string CC_MODNAME = "CConsole";
        public override void Load()
        {
            if (IL2CPPChainloader.Instance.Plugins.ContainsKey(CC_MODNAME))
            {
                DinoLogger.Error("CConsole detected (incompatible). Skipping loading " + MODNAME);
                return;
            }

            Log.LogMessage("Loading " + MODNAME);
            new Harmony(MODNAME).PatchAll();
            Log.LogMessage("Loaded " + MODNAME);
        }
    }
}