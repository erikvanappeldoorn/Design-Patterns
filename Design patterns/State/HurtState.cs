using System;

namespace Design_Patterns.State
{
    public class HurtState : IPlayerState
    {
        public void Execute(Player player)
        {
            Console.WriteLine("The player is wounded, search for health!");
        }
    }
}