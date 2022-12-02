using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point();
            point1.Print();
            var point2 = new Point(3, 14);
            Console.WriteLine(point2.Norm());
            point2.Set(1, 2);
            point2.Print();
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Set(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double Norm()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
        public void Print()
        {
            Console.WriteLine($"({X},{Y})");
        }


    }
}
