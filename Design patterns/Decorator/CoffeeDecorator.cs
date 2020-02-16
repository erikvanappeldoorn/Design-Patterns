using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee coffee;

        protected string name = "";
        protected double price = 0.0;

        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public double Cost => coffee.Cost + price;

        public string GetDescription() => $"{coffee.GetDescription()}, {name}";
        
    }
}
