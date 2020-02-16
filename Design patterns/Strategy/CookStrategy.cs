using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }
}
