using System;

namespace Design_Patterns.Strategy
{
    public class MicrowaveStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} by microwaving it");
        }
    }
}
