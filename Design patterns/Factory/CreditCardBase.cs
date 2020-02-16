using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Factory
{
    public abstract class CreditCardBase
    {
        public abstract string CardType { get; }

        public abstract int Limit { get; set; }

        public abstract int AnnualCharge { get; set; }
    }
}
