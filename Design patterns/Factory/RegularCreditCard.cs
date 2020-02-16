using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Factory
{
    public class RegularCreditCard : CreditCardBase
    {
        private string cardType;
        private int limit;
        private int annualCharge;
        public RegularCreditCard(int limit, int annualCharge)
        {
            cardType = "Regular";
            this.limit = limit;
            this.annualCharge = annualCharge;
        }
        public override string CardType => cardType;

        public override int Limit { get => limit; set => limit = value; }
        public override int AnnualCharge { get => annualCharge; set => annualCharge = value; }
    }
}
