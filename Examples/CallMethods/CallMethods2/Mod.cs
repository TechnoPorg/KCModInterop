using Porg;
using System.Reflection;

namespace Examples.CallMethods.CallMethods2
{
    class CallMethods2
    {
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("CallMethods2");
        }
        static int AddSeventyThree(int num) => num + 73;
    } 
}