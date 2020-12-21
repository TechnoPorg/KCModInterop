using Porg;
using System.Reflection;

namespace Examples.UseClasses.UseClasses2
{
    class UseClasses2
    {
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("UseClasses2");
        }
    }
    class DemoClass
    {
        string message;
        public DemoClass()
        {
            message = "Hello!";
        }
        public DemoClass(string _message)
        {
            message = _message;
        }
        public void LogMessage(KCModHelper helper)
        {
            helper.Log(message);
        }
    }
}