using Porg;
using System;
using System.Reflection;

namespace Examples.UseClasses.UseClasses1
{
    class UseClasses1
    {
        Assembly modAssembly;
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("UseClasses1");
        }
        public void PreScriptLoad(KCModHelper helper)
        {
            if (!InteropClient.TryGetMod("UseClasses2", out modAssembly)) return;
            Type classType = modAssembly.GetType("Examples.UseClasses.UseClasses2.DemoClass");
            MethodInfo logMessage = classType.GetMethod("LogMessage", Harmony.AccessTools.all);
            object instance = Activator.CreateInstance(classType);
            logMessage.Invoke(instance, new object[] { helper });
            instance = Activator.CreateInstance(classType, new object[] { "Goodbye!" });
            logMessage.Invoke(instance, new object[] { helper });
        }
    } 
}