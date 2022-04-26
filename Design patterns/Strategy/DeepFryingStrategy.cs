using System;

namespace Design_Patterns.Strategy
{
    public class DeepFryingStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} deep frying it");
        }
    }
}
