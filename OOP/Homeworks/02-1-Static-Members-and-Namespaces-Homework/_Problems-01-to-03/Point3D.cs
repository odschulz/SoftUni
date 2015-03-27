using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problems_01_to_03
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint = new Point3D();

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3D()
            : this(0, 0, 0)
        {
        }

        public double X
        {
            get { return this.x; }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get { return this.y; }
            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get { return this.z; }
            set
            {
                this.z = value;
            }
        }

        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }

        public override string ToString()
        {
            return String.Format("coordinate X = {0}, coordinate Y = {1}, coordinate Z = {2};", this.X, this.Y, this.Z);
        }
    }
}
