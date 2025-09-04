namespace Course7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int cnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cnt; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used ou imported? (c/u/i)?: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();


                Console.Write("Price: ");
                double prc = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    Product imProduct = new ImportedProduct(name, prc, fee);
                    products.Add(imProduct);
                }

                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateOnly dateOnly = DateOnly.Parse(Console.ReadLine());
                    Product usedProduct = new UsedProduct(name, prc, dateOnly);
                    products.Add(usedProduct);
                }
                else if (ch == 'c')
                {
                    Product product = new Product(name, prc);
                    products.Add(product);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}