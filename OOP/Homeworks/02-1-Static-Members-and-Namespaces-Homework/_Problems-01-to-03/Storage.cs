using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Problems_01_to_03
{
    static class Storage
    {
        const string filePath = @"..\..\Files\";
        public static void WritePathToFile(string fileName, Path3D paths)
        {
            using (StreamWriter writer = new StreamWriter(filePath + fileName, true))
            {
                foreach (Point3D point in paths)
                {
                    writer.WriteLine(point);
                }
            }
        }
        public static Path3D ReadPathFromFile(string fileName)
        {
            ValidationMethods.CheckIfFileExists(filePath + fileName);
            Path3D pathsList = new Path3D();
            using (StreamReader reader = new StreamReader(filePath + fileName))
            {
                string line;
                Match match;
                byte lineNumber = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    match = Regex.Match(line, @".*X\s=\s([\d.]+),.*Y\s=\s([\d.]+),\s.*Z\s=\s([\d.]+);");
                    if (match.Success)
                    {
                        double pointX = Double.Parse(match.Groups[1].Value);
                        double pointY = Double.Parse(match.Groups[2].Value);
                        double pointZ = Double.Parse(match.Groups[3].Value);
                        pathsList.AddPoint(new Point3D(pointX, pointY, pointZ));
                    }
                    else
                    {
                        throw new InvalidDataException(String.Format(
                            "Invalid point coordinates in file: \'{0}\', line number: {1}", filePath + fileName, 
                            lineNumber));
                    }
                    lineNumber++;
                }
            }
            return pathsList;
        }
    }
}
