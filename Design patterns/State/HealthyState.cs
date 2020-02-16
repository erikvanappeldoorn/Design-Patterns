using System;

namespace Design_Patterns.State
{
    public class HealthyState : IPlayerState
    {
        public void Execute(Player player)
        {
            Console.WriteLine("The player is in healthy state");
        }
    }
}