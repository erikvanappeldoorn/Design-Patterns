using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    public class SwitchDownCommand : ICommand
    {
        private readonly Light light;

        public SwitchDownCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
    }
}
