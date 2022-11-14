using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    public class Circle : Shape
    {
        double radius;
        public Circle (double radius)
        {
            name = "Cerchio";

            this.radius = radius;
        }

        public override double Area() 
        {
            return radius * radius * 3.14;
        }
        public override double Perimeter() 
        {
            return radius * 2 * 3.14;
        }
    }
}
