using PolimorfismInheritanceExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismInheritanceExercise.Models
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        

        public UsedProduct()
        {
            
        }

        public UsedProduct(string name, double price, ProductType productType, DateTime manufactureDate)
            :base(name, price, productType)
        {
            ManufactureDate = manufactureDate;
        }


        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append($"{Name} - {PriceTag()} - ");
            msg.Append($"Tipo: {ProductType.Used.ToString()} - Manufacture Date: {ManufactureDate.ToShortDateString()}");

            return msg.ToString();
        }
    }
}
