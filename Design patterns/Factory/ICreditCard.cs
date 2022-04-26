namespace Design_Patterns.Factory
{
    public interface ICreditCard
    {
        public string CardType { get; }

        public int Limit { get; set; }

        public int AnnualCharge { get; set; }
    }
}
