using CustomExceptions.Models;
using CustomExceptions.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine();
                Console.Write(reservation);

                Console.ReadKey();
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Error in reservation: {ex.Message}");
                Console.ReadKey();
            }
           
        }
    }
}
