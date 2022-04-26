namespace Design_Patterns.Factory
{
    public class PlatinumCreditCard : ICreditCard
    {
        private string cardType;
        private int limit;
        private int annualCharge;
        public PlatinumCreditCard(int limit, int annualCharge)
        {
            cardType = "Platinum card";
            this.limit = limit;
            this.annualCharge = annualCharge;
        }
        public string CardType => cardType;

        public int Limit { get => limit; set => limit = value; }
        public int AnnualCharge { get => annualCharge; set => annualCharge = value; }
    }
}
