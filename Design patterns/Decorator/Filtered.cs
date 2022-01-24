using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class Filtered : ICoffee
    {
        public double Cost => 3.05;

        public string GetDescription() => "Filtered coffee";
    }
}
