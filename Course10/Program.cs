using System.Globalization;

namespace Course10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Throw away that weight, often it's not even yours
            List<TaxPayerClass> list = new List<TaxPayerClass>();

            Console.Write("Enter the number of tax payers: ");
            int mrn = int.Parse(Console.ReadLine());

            for (int i = 1; i <= mrn; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company? (I/C): ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Name: ");
                    string nameI = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncomeI = double.Parse(Console.ReadLine());

                    Console.Write("Health expenditures: ");
                    double healthI = double.Parse(Console.ReadLine());

                    TaxPayerClass taxPayerClass = new IndividualClass(nameI, anualIncomeI, healthI);
                    list.Add(taxPayerClass);
                }
                else if (ch == 'c' || ch == 'C'){
                    Console.Write("Name: ");
                    string nameC = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncomeC = double.Parse(Console.ReadLine());

                    Console.Write("Number of employees: ");
                    int empC = int.Parse(Console.ReadLine());

                    TaxPayerClass taxPayerClass = new CompanyClass(nameC, anualIncomeC, empC);
                    list.Add(taxPayerClass);
                }
                else
                {
                    Console.WriteLine("Invalid option, taking off my stuff's");
                }
            }
            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayerClass tp in list)
            {
                double impostoCalculado = tp.Tax();
                Console.WriteLine($"{tp.Name}: $ {impostoCalculado.ToString("F2")}");
                sum += impostoCalculado;
            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}