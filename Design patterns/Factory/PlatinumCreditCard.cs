using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Factory
{
    public class PlatinumCreditCard : CreditCardBase
    {
        private string cardType;
        private int limit;
        private int annualCharge;
        public PlatinumCreditCard(int limit, int annualCharge)
        {
            cardType = "Platinum";
            this.limit = limit;
            this.annualCharge = annualCharge;
        }
        public override string CardType => cardType;

        public override int Limit { get => limit; set => limit = value; }
        public override int AnnualCharge { get => annualCharge; set => annualCharge = value; }
    }
}
