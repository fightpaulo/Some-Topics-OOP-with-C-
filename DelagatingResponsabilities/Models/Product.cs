using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatingResponsabilities.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product() { }

        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public double TotalValueInStock()
        {
            return Price * Amount;
        }

        public void Add(int amount)
        {
            Amount += amount;
        }

        public void Remove(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine($"Nome: {Name}");
            message.AppendLine($"Preço: {Price}");
            message.AppendLine($"Quantidade no estoque: {Amount}");

            return message.ToString();
        }
    }
}
