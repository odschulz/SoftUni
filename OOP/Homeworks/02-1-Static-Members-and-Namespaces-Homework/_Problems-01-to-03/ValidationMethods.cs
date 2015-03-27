using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problems_01_to_03
{
    class ValidationMethods
    {
        public static void ValidateDouble(double value, string parameter)
        {
            if (value < 0)
            {
                throw new ArgumentNullException("\"" + parameter + "\"" + "cannot be a negative number!");
            }
        }
        public static void IsInList(Point3D point, IList<Point3D> list)
        {
            if (!list.Contains(point))
            {
                throw new ArgumentOutOfRangeException("No such point in the current object");
            }
        }
        public static void CheckIfFileExists(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException(String.Format("The file \"{0}\" does not exist!", file));
            }
        }
    }
}
