using Porg;
using System.Reflection;

namespace Examples.AccessFields.AccessFields2
{
    class AccessFields2
    {
        static string myString = "Hello from AccessFields2!";
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("AccessFields2");
        }
    } 
}