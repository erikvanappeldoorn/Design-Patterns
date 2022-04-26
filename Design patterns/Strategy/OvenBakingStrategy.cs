using System;

namespace Design_Patterns.Strategy
{
    public class OvenBakingStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} by oven baking it");
        }
    }
}
