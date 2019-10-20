using CustomExceptions.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions.Models
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            DateTime now = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            if (checkIn < now || checkOut < now)
                throw new DomainException("Reservation dates for update must be future dates.");

            if (checkOut <= checkIn)
                throw new DomainException("Check-out date must be after check-in date.");

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("-- Reservation --");
            msg.AppendLine($"Room Number: {RoomNumber}");
            msg.AppendLine($"Check-in: {CheckIn.ToShortDateString()}");
            msg.AppendLine($"Check-out: {CheckOut.ToShortDateString()}");
            msg.AppendLine($"Total days: {Duration()}");

            return msg.ToString();
        }
    }
}
