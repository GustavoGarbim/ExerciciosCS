namespace Course10
{
    abstract class TaxPayerClass
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayerClass(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
