using Porg;
using System.Reflection;

namespace Examples.PatchMethods.PatchMethods2
{
    class PatchMethods2
    {
        public string name;
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("PatchMethods2");
            name = "Elon Musk";
        }
        public void SceneLoaded(KCModHelper helper)
        {
            helper.Log("The scene has loaded!");
        }
    }
}