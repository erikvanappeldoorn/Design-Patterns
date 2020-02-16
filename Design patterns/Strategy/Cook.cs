using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public class Cook
    {
        private readonly CookStrategy strategy;

        public Cook(CookStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void StartCooking(string food)
        {
            strategy.Cook(food);
        }
    }
}
