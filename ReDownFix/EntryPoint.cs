﻿using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace ModBase
{
    [BepInPlugin("Dinorush." + MODNAME, MODNAME, "1.0.0")]
    internal sealed class EntryPoint : BasePlugin
    {
        public const string MODNAME = "ReDownFix";

        public override void Load()
        {
            Log.LogMessage("Loading " + MODNAME);
            new Harmony(MODNAME).PatchAll();
            Log.LogMessage("Loaded " + MODNAME);
        }
    }
}