using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
            price = 0.85;
            name = "Chocolate";
        }
    }
}
