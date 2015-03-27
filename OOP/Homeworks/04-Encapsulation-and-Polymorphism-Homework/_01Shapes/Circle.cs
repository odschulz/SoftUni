using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    public class Circle : BasicShape
    {
        public Circle(double radius)
            : base(radius, radius)
        {
            
        }
        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.Height, 2);
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Height;
            return perimeter;
        }
    }
}
