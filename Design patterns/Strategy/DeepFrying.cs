using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} deep frying it");
        }
    }
}
