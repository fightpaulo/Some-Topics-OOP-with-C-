using PolimorfismInheritanceExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismInheritanceExercise.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType ProductType { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, ProductType productType)
        {
            ProductType = productType;
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"$ {Price}";
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();

            msg.Append($"{Name} - {PriceTag()} - Tipo: {ProductType.Common.ToString()}");

            return msg.ToString();
        }
    }
}
