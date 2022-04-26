namespace Design_Patterns.Factory
{
    public class RegularCreditCard : ICreditCard
    {
        private string cardType;
        private int limit;
        private int annualCharge;
        public RegularCreditCard(int limit, int annualCharge)
        {
            cardType = "Regular card";
            this.limit = limit;
            this.annualCharge = annualCharge;
        }
        public string CardType => cardType;

        public int Limit { get => limit; set => limit = value; }
        public int AnnualCharge { get => annualCharge; set => annualCharge = value; }
    }
}
