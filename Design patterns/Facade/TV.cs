using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade
{
    public class TV
    {
        public void SwitchOn() => Console.WriteLine("TV switched on");

        public void SwitchOff() => Console.WriteLine("TV switched off");
    }
}
