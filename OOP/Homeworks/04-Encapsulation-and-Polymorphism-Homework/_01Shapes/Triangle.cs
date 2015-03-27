using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    public class Triangle : BasicShape
    {

        private double c;
        public Triangle(double a, double b, double c)
            : base(a, b)
        {
            this.C = c;
        }


        public double C
        {
            get { return this.c; }
            set
            {
                this.c = value;
            }
        }
        public override double CalculateArea()
        {
            //Heron's formula
            double p = this.CalculatePerimeter() / 2;
            double area = Math.Sqrt(p * (p - this.Width) * (p - this.Height) * (p - this.C));
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width + this.Height + this.C;
            return perimeter;
        }
    }
}
