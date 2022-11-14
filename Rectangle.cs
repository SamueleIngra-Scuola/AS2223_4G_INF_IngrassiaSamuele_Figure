using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    public class Rectangle : Shape
    {
        double b;
        double height;

        public Rectangle (double b, double height)
        {
            name = "Rettngolo";

            this.b = b;
            this.height = height;
        }

        public override double Area() 
        {
            return b * height;
        }
        public override double Perimeter() 
        {
            return b * 2 + height * 2;
        }
    }
}
