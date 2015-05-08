using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problems_01_to_03
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("--------------------Point3D---------------------");
            Point3D point1 = new Point3D(1, 2.2, 3);
            Point3D point2 = new Point3D(33.5, 55, 8);
            Console.WriteLine("Starting point: {0}\nPoint1: {1}\nPoint2: {2}", Point3D.StartingPoint, point1, point2);

            Console.WriteLine("\n--------------------Distance Calculator---------------------");
            double distance = DistanceCalculator.CalculateDistance(point1, Point3D.StartingPoint);
            Console.WriteLine("Distance between starting point and Point1: {0};", distance);

            Console.WriteLine("\n--------------------Path3D----------------------");
            Path3D path = new Path3D(Point3D.StartingPoint, point1, point2);
            Console.WriteLine("A path instance holding all points:\n{0}", path);
            path.RemovePoint(point2);
            Console.WriteLine("Removed last point:\n{0}", path);
            path.AddPoint(point2);
            Console.WriteLine("Added last point again:\n{0}", path);

            Console.WriteLine("\n-------------------Storage---------------------");
            //Check the folder Files in the solution for the stored paths file.
            //You can create a new file in that same folder, by changing the file name below
            string fileName = "StoredPaths.txt";
            Storage.WritePathToFile(fileName, path);
            Path3D pathsFromFile = Storage.ReadPathFromFile(fileName);
            Console.WriteLine(pathsFromFile);
        }
    }
}
