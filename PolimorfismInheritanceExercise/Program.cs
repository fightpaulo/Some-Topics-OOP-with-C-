using PolimorfismInheritanceExercise.Models;
using PolimorfismInheritanceExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismInheritanceExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExerciseAboutProducts();
        }

        private static void ExerciseAboutProducts()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Common, Used or Imported (c/u/i): ");
                ProductType productType = (ProductType) Convert.ToChar(Console.ReadLine());

                if (productType == ProductType.Imported)
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, ProductType.Imported, customsFee));
                }
                else if (productType == ProductType.Used)
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, ProductType.Used, data));
                }
                else
                {
                    products.Add(new Product(name, price, ProductType.Common));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }

        private void ExerciseAboutEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");

                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
