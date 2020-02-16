using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Factory
{
    public abstract class CreditCardFactoryBase
    {
        public abstract CreditCardBase GetCreditCard();
    }
}
