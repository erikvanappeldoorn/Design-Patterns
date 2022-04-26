namespace Design_Patterns.Factory
{
    public class RegularCreditCardFactory : ICreditCardFactory
    {
        private readonly int limit;
        private readonly int annualCharge;

        public RegularCreditCardFactory(int limit, int annualCharge)
        {
            this.limit = limit;
            this.annualCharge = annualCharge;
        }
        public ICreditCard GetCreditCard()
        {
            return new RegularCreditCard(limit, annualCharge);
        }
    }
}
