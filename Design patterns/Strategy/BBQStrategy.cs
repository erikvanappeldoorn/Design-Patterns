using System;

namespace Design_Patterns.Strategy
{
    public class BBQStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} by BBQ it");
        }
    }
}