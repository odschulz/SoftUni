using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problems_01_to_03
{
    class DistanceCalculator
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            return Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2) + Math.Pow(p1.Z - p2.Z, 2);
        }
    }
}
