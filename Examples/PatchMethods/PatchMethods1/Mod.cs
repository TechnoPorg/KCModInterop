using Porg;
using Harmony;
using System.Reflection;

namespace Examples.PatchMethods.PatchMethods1
{
    class PatchMethods1
    {
        Assembly modAssembly;
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("PatchMethods1");
        }
        public void PreScriptLoad(KCModHelper helper)
        {
                if (!InteropClient.TryGetMod("PatchMethods2", out modAssembly)) return;
                HarmonyInstance instance = HarmonyInstance.Create("PatchMethods2");
                instance.Patch(modAssembly.GetType("Examples.PatchMethods.PatchMethods2.PatchMethods2").GetMethod("SceneLoaded"), prefix: new HarmonyMethod(typeof(PatchMethods1).GetMethod("PatchPrefix", Harmony.AccessTools.all)));
        }
        static void PatchPrefix(object __instance, KCModHelper helper)
        {
            helper.Log("The name of this instance is:");
            helper.Log(__instance.GetType()
                                   .GetField("name")
                                   .GetValue(__instance)
                                   .ToString());
        }
    }
}
