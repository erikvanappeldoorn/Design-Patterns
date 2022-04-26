using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Factory
{
    public class PlatinumCreditCardFactory : ICreditCardFactory
    {
            private readonly int limit;
            private readonly int annualCharge;

            public PlatinumCreditCardFactory(int limit, int annualCharge)
            {
                this.limit = limit;
                this.annualCharge = annualCharge;
            }
            public ICreditCard GetCreditCard()
            {
                return new PlatinumCreditCard(limit, annualCharge);
            }
    }
}
