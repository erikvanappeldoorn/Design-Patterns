using System;

namespace Design_Patterns.Strategy
{
    public class GrillingStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} by grilling it.");
        }
    }
}
