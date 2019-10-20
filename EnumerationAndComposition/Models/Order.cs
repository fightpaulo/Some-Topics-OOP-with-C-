using EnumerationAndComposition.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationAndComposition.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order() { }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine($"Id: {Id}");
            message.AppendLine($"Moment: {Moment}");
            message.AppendLine($"Status: {Status.ToString()}");

            return message.ToString();
        }
    }
}
