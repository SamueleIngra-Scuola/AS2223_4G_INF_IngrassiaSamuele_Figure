using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLIB
{
    public class Square : Shape
    {
        double edge;
        public Square(double edge)
        {
            name = "Quadrato";

            this.edge = edge;
        }


        public override double Area
        {
            get
            {
                return edge * edge;
            }
        }

        public override double Perimeter
        {
            get
            {
                return edge * 4;
            }
        }
    }
}
