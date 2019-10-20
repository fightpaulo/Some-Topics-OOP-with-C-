using ClassAndMethodsAbstract.Models;
using ClassAndMethodsAbstract.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstract
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // It's important create a list of generic type.
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number os shapes:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1}: ");
                Console.Write("Rectangle or Circle (r/c): ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine(), true);

                switch (ch)
                {
                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Circle(radius, color));
                        break;

                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Rectangle(width, height, color));
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("SHAPES ÁREA: ");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}"); 
            }


            Console.ReadKey();
        }
    }
}
