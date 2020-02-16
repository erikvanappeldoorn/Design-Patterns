using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade
{
    public class HomeSecuritySystem
    {
        public void Enable() => Console.WriteLine("Home Security System enabled");

        public void Disable() => Console.WriteLine("Home Security System disabled");
    }
}
