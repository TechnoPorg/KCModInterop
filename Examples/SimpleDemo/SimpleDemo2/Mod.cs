using Porg;
using System.Reflection;

namespace Examples.SimpleDemo.SimpleDemo2
{
    class SimpleDemo2
    {
        public void Preload(KCModHelper helper)
        {
            InteropClient.Register("SimpleDemo2");
        }
    } 
}