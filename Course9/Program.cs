using Course9.Entities;
using Course9.Entities.Enums;
using System.Globalization;

namespace Course9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> list = new List<Shapes>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)?: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            foreach (Shapes s in list)
            {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}