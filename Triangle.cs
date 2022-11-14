using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    public class Triangle : Shape
    {
        double b;
        double height;
        public Triangle (double b, double height)
        {
            name = "Triangle";

            this.b = b;
            this.height = height;
        }

        public override double Area() 
        {
            return b * height / 2;
        }
        public override double Perimeter() 
        {
            return b * 3;
        }
    }
}
