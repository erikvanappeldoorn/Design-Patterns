using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State
{
    public class Player
    {
        private IPlayerState currentState;

        public Player()
        {
            currentState = new HealthyState();
        }

        public void HittedByBullets(int numberOfBullets)
        {
            if (numberOfBullets < 5)
            {
                currentState = new HealthyState();
            }
            else if (numberOfBullets >= 5 && numberOfBullets < 10)
            {
                currentState = new HurtState();
            }
            else
            {
                currentState = new DeadState();
            }

            currentState.Execute(this);
        }
    }
}
