using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Factory
{
    public class PlatinumCreditCardFactory : CreditCardFactoryBase
    {
            private readonly int limit;
            private readonly int annualCharge;

            public PlatinumCreditCardFactory(int limit, int annualCharge)
            {
                this.limit = limit;
                this.annualCharge = annualCharge;
            }
            public override CreditCardBase GetCreditCard()
            {
                return new PlatinumCreditCard(limit, annualCharge);
            }
    }
}
