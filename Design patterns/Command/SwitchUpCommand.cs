using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    public class SwitchUpCommand : ICommand
    {
        private readonly Light light;

        public SwitchUpCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOn();
        }
    }
}
