using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problems_01_to_03
{
    class Path3D : IEnumerable<Point3D>
    {
        private IList<Point3D> points;
        public Path3D(params Point3D[] points)
        {
            this.Points = points.ToList();
        }

        public IList<Point3D> Points 
        { 
            get { return this.points; } 
            set { this.points = value; } 
        }

        public void AddPoint(Point3D newPoint)
        {
            this.Points.Add(newPoint);
        }

        public void RemovePoint(Point3D pointToRemove)
        {
            ValidationMethods.IsInList(pointToRemove, this.Points);
            this.Points.Remove(pointToRemove);
        }

        public override string ToString()
        {
            return string.Join("\n", this.points);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.Points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Points.GetEnumerator();
        }
    }
}
