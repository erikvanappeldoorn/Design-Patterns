using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade
{
    public class Lights
    {
        public void SwitchOn() => Console.WriteLine("Lights switched on");

        public void SwitchOff() => Console.WriteLine("Lights switched off");
    }
}
