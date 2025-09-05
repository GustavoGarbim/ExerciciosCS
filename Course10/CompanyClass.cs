namespace Course10
{
    class CompanyClass : TaxPayerClass
    {
        public int NumberOfEmployees { get; set; }

        public CompanyClass(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome) 
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
