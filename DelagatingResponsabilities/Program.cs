using DelagatingResponsabilities.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatingResponsabilities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle x = new Triangle();
            //Triangle y = new Triangle();

            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //x.A = double.Parse(Console.ReadLine());
            //x.B = double.Parse(Console.ReadLine());
            //x.C = double.Parse(Console.ReadLine());
            //double areaX = x.Area();

            //Console.WriteLine("Entre com as medidas do triângulo Y:");
            //y.A = double.Parse(Console.ReadLine());
            //y.B = double.Parse(Console.ReadLine());
            //y.C = double.Parse(Console.ReadLine());
            //double areaY = y.Area();

            //Console.WriteLine();
            //Console.WriteLine($"Área de X: {areaX.ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"Área de Y: {areaY.ToString("F2", CultureInfo.InvariantCulture)}");

            //Console.WriteLine("\n------------------------------------------------------------------");

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int amount = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, amount);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite a quantidade de produtos a ser adicionada ao estoque: ");
            amount = int.Parse(Console.ReadLine());
            p.Add(amount);

            Console.Write("Digite a quantidade de produtos a ser removida do estoque: ");
            amount = int.Parse(Console.ReadLine());
            p.Remove(amount);

            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadKey();
        }
    }
}
