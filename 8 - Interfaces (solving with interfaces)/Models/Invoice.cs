using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine($"Basic Payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}");
            msg.AppendLine($"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}");
            msg.Append($"Total Payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");

            return msg.ToString();
        }
    }
}
