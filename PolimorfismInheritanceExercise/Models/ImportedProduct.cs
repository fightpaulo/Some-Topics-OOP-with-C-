using PolimorfismInheritanceExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismInheritanceExercise.Models
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, double price, ProductType productType, double customsFee)
            :base(name, price, productType)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{TotalPrice().ToString(CultureInfo.InvariantCulture)}";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append($"{Name} - {PriceTag()} - ");
            msg.Append($"Tipo: {ProductType.Imported.ToString()} - Customs Fee: {CustomsFee}");

            return msg.ToString();
        }
    }
}
