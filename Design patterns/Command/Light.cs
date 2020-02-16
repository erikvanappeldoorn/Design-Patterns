using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }
}
