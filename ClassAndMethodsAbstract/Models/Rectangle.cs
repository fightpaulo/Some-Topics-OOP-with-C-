using ClassAndMethodsAbstract.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAbstract.Models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
            :base(color)
        {
            Width = width;
            Height = height;
        }

        // An abstract method, for standard, is also a virtual method
        public override double Area()
        {
            return Width * Height;
        }
    }
}
