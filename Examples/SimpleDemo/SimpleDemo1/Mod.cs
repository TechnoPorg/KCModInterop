using Porg;
using System.Reflection;

namespace Examples.SimpleDemo.SimpleDemo1
{
    class SimpleDemo1
    {
        Assembly modAssembly;
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("SimpleDemo1");
        }
        public void PreScriptLoad(KCModHelper helper)
        {
            if (!InteropClient.TryGetMod("SimpleDemo2", out modAssembly)) return;
            helper.Log("Successfully loaded SimpleDemo2");
        }
    } 
}