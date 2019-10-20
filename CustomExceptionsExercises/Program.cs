using CustomExceptionsExercises.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Value to withdraw: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                Account acc = new Account(number, holder);
                acc.Withdraw(value);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
