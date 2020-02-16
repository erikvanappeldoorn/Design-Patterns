using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class Espresso : ICoffee
    {
        public double Cost => 1.95;

        public string GetDescription() => "Espresso coffee";
    }
}
