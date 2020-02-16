using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    public class Switch
    {
        private List<ICommand> commands = new List<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            commands.Add(command);
            command.Execute();
        }
    }
}
