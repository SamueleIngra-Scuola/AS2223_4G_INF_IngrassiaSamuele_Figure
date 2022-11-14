using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    public class Square : Shape
    {
        double edge;
        public Square (double edge)
        {
            name = "Square";

            this.edge = edge;
        }

        public override double Area() 
        {
            return edge * edge;
        }
        public override double Perimeter() 
        {
            return edge * 4;
        }
    }
}
