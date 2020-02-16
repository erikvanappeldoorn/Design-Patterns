using System;

namespace Design_Patterns.State
{
    public class DeadState : IPlayerState
    {
        public void Execute(Player player)
        {
            Console.WriteLine("The player is in dead state");
        }
    }
}