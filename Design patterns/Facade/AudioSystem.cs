using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade
{
    public class AudioSystem
    {
        public void SwitchOn() => Console.WriteLine("Audio system switched on");

        public void SwitchOff() => Console.WriteLine("Audio system switched off");
    }
}
