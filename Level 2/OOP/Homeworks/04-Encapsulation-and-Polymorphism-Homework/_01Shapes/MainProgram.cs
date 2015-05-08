using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4, 5);
            Triangle triangle = new Triangle(10, 10, 10);
            Circle circle = new Circle(5);

            List<IShape> figures = new List<IShape> {rectangle, triangle, circle};
            foreach (var shape in figures)
            {
                Console.WriteLine(shape.GetType().Name + ":");
                Console.WriteLine("Perimeter: " + shape.CalculatePerimeter());
                Console.WriteLine("Area: " + shape.CalculateArea());
                Console.WriteLine();
            }
        }
    }
}
