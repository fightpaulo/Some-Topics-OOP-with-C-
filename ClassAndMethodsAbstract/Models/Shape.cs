using ClassAndMethodsAbstract.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstract.Models
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        // As this constructor is not implemented
        // I'll be required to implement in subclasses one that has paremeters
        //public Shape()
        //{

        //}

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

        // We can have a common method inside an abstract class
        public void ShowMessage()
        {
            Console.WriteLine("It's a shape!");
        }
    }
}
