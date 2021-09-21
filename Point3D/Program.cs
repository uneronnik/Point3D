using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
        new public string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
    public class Point3D<T> : Point2D<T>
    {
        public T Z { get; set; }
        public Point3D(T x, T y, T z)
            :base(x, y)
        {
            Z = z;
        }
        public Point3D()
            :base()
        {
            Z = default(T);
        }
        new public string ToString()
        {
            return base.ToString() + $", Z: {Z}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3D<int> point3D = new Point3D<int>(5, 10, 15);
            Console.WriteLine(point3D.ToString());
            Console.WriteLine(((Point2D<int>)point3D).ToString());
            Console.ReadKey();
        }
    }
}
