using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLIB
{
    public class Rectangle : Shape
    {
        double b;
        double height;

        public Rectangle (double b, double height)
        {
            name = "Rettangolo";

            this.b = b;
            this.height = height;
        }


        public override double Area
        {
            get
            {
                return b * height;
            }
        }


        public override double Perimeter 
        {
            get
            {
                return b * 2 + height * 2;
            }
        }
    }
}
