using HarmonyLib;

namespace ReDownFix
{
    [HarmonyPatch]
    internal static class PlayerDamagePatch
    {
        [HarmonyPatch(typeof(Dam_PlayerDamageBase), nameof(Dam_PlayerDamageBase.OnIncomingDamage))]
        [HarmonyWrapSafe]
        [HarmonyPrefix]
        private static bool Pre_OnDamage(Dam_PlayerDamageBase __instance, ref bool __result)
        {
            __result = true;
            return __instance.Owner.Alive;
        }
    }
}
