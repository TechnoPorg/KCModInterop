using Porg;
using System.Reflection;
using System;

namespace Examples.CallMethods.CallMethods1
{
    class CallMethods1
    {
        Assembly modAssembly;
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("CallMethods1");
        }
        public void PreScriptLoad(KCModHelper helper)
        {
            if (!InteropClient.TryGetMod("CallMethods2", out modAssembly)) return;
            Type type = modAssembly.GetType("Examples.CallMethods.CallMethods2.CallMethods2");
            MethodInfo method = type.GetMethod("AddSeventyThree", Harmony.AccessTools.all);
            helper.Log(((int)method.Invoke(null, new object[] { 56 })).ToString());
            Func<int, int> delegateMethod = (Func<int, int>)Delegate.CreateDelegate(typeof(Func<int, int>), method);
            helper.Log(delegateMethod(56).ToString());
        }
    } 
}