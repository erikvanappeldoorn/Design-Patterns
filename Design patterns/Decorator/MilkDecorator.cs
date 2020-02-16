using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            name = "Milk";
            price = 0.25;
        }
    }
}
