using Porg;
using System.Reflection;
using System;
using Harmony;

namespace Examples.AccessFields.AccessFields1
{
    class AccessFields1
    {
        Assembly modAssembly;
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("AccessFields1");
        }
        public void PreScriptLoad(KCModHelper helper)
        {
            if (!InteropClient.TryGetMod("AccessFields2", out modAssembly)) return;
            Type fieldClass = modAssembly.GetType("Examples.AccessFields.AccessFields2.AccessFields2");
            FieldInfo field = fieldClass.GetField("myString", Harmony.AccessTools.all);
            helper.Log((string)field.GetValue(null));
        }
    } 
}