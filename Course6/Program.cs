using Course6.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); 

            Console.Write("Enter the number of employees: ");
            int M = int.Parse(Console.ReadLine());

            for (int a = 1; a <= M; a++)
            {
                Console.WriteLine($"Employee #{a} data: ");
                Console.Write("Outsourced (y/n): ");
                char ri = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string na = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ri == 'y')
                {
                    Console.Write("Additional charge: ");
                    double charge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(na, hours, valuePerHour, charge));
                }
                else
                {
                    list.Add(new Employee(na, hours, valuePerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}