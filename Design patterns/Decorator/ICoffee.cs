using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator
{
    public interface ICoffee
    {
        string GetDescription();
        double Cost { get;  }
    }
}
