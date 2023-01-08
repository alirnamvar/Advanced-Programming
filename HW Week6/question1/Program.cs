using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            int n = int.Parse(Console.ReadLine());
            string line2 = Console.ReadLine();
            string[] shapeNumbers = line2.Split(' ').ToArray();

            foreach (var shapeNumber in shapeNumbers)
            {
                string input = Console.ReadLine();
                shapes.Add(ShapeMaker.Make(input, int.Parse(shapeNumber)));
            }

            foreach (IShape shape in shapes)
            {
                shape.Describe();
            }
            
        }
    }

    public static class ShapeMaker
    {
        public static IShape Make(string input, int shapeNumber)
        {
            IShape shape = null;
            string[] splitedInput = Regex.Split(input, " : ", RegexOptions.IgnoreCase);
            string[] points = splitedInput[1].Split(' ');

            if (shapeNumber == 1)
            {
                shape = new Triangle(
                    splitedInput[0],
                    points[0],
                    points[1],
                    points[2]);
            }
            else if (shapeNumber == 2)
            {
                shape = new Rectangle(
                    splitedInput[0],
                    points[0],
                    points[1],
                    points[2],
                    points[3]);
            }
            else if (shapeNumber == 3)
            {
                shape = new Rhombus(
                    splitedInput[0],
                    points[0],
                    points[1],
                    points[2],
                    points[3]);
            }
            else if (shapeNumber == 4)
            {
                shape = new Square(
                    splitedInput[0],
                    points[0],
                    points[1],
                    points[2],
                    points[3]);
            }
            else if (shapeNumber == 5)
            {
                shape = new Hexagon(
                    splitedInput[0],
                    new List<string> 
                    { 
                        points[0],
                        points[1],
                        points[2],
                        points[3],
                        points[4],
                        points[5],
                    });
            }
            else if (shapeNumber == 6)
            {
                shape = new Octagon(
                    splitedInput[0],
                    new List<string>
                    {
                        points[0],
                        points[1],
                        points[2],
                        points[3],
                        points[4],
                        points[5],
                        points[6],
                        points[7],
                    });
            }
            return shape;
        }
    }

    public class Octagon : IShape, IShapeMoreThan4Side
    {
        private string Name { get; }
        private double Area { get; set; }
        private double Perimeter { get; set; }
        private List<Point> Points { get; }
        private List<double> Diameters { get; set; }
        public Octagon(string name, List<string> points)
        {
            Name = name;
            Diameters = new List<double>();

            foreach (var item in points)
            {
                string[] inp = item.Split(':');
                Points.Add(new Point(double.Parse(inp[0]), double.Parse(inp[1])));
            }

            CalculateAndSaveDiameters();

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        public double CalculatePerimeter()
        {
            return 8 * CalculateDistance(Points[0], Points[1]);
        }

        public double CalculateArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(CalculateDistance(Points[0], Points[1]), 2);
        }

        public void CalculateAndSaveDiameters()
        {
            Diameters.Add(CalculateDistance(Points[0], Points[2]));
            Diameters.Add(CalculateDistance(Points[0], Points[3]));
            Diameters.Add(CalculateDistance(Points[0], Points[4]));
            Diameters.Add(CalculateDistance(Points[0], Points[5]));
            Diameters.Add(CalculateDistance(Points[0], Points[6]));

            Diameters.Add(CalculateDistance(Points[1], Points[3]));
            Diameters.Add(CalculateDistance(Points[1], Points[4]));
            Diameters.Add(CalculateDistance(Points[1], Points[5]));
            Diameters.Add(CalculateDistance(Points[1], Points[6]));
            Diameters.Add(CalculateDistance(Points[1], Points[7]));

            Diameters.Add(CalculateDistance(Points[2], Points[4]));
            Diameters.Add(CalculateDistance(Points[2], Points[5]));
            Diameters.Add(CalculateDistance(Points[2], Points[6]));
            Diameters.Add(CalculateDistance(Points[2], Points[7]));

            Diameters.Add(CalculateDistance(Points[3], Points[5]));
            Diameters.Add(CalculateDistance(Points[3], Points[6]));
            Diameters.Add(CalculateDistance(Points[3], Points[7]));

            Diameters.Add(CalculateDistance(Points[4], Points[6]));
            Diameters.Add(CalculateDistance(Points[4], Points[7]));

            Diameters.Add(CalculateDistance(Points[5], Points[7]));
        }

        public double[] GetDiametersInDescending()
        {
            return Diameters.OrderByDescending(x => x).ToArray();
        }

        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
        public void Describe()
        {
            string final = $"{Name} : ";
            final += String.Format("{0:.00}", CalculatePerimeter()) + " "
                + String.Format("{0:.00}", CalculateArea())
                + " ";
            foreach (double item in GetDiametersInDescending())
            {
                final += " " + String.Format("{0:.00}", item);
            }
            Console.WriteLine(final);
        }
    }

    public class Hexagon : IShape, IShapeMoreThan4Side
    {
        private string Name { get; }
        private double Area { get; set; }
        private double Perimeter { get; set; }
        private List<Point> Points { get; }
        private List<double> Diameters { get; set; }
        public Hexagon(string name, List<string> points)
        {
            Name = name;
            Diameters = new List<double>();

            foreach (var item in points)
            {
                string[] inp = item.Split(':');
                Points.Add(new Point(double.Parse(inp[0]), double.Parse(inp[1])));
            }

            CalculateAndSaveDiameters();

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        public double CalculatePerimeter()
        {
            return 6 * CalculateDistance(Points[0], Points[1]);
        }

        public double CalculateArea()
        {
            return 2.5980762 * Math.Pow(CalculateDistance(Points[0], Points[1]), 2);
        }

        public void CalculateAndSaveDiameters()
        {
            Diameters.Add(CalculateDistance(Points[0], Points[2]));
            Diameters.Add(CalculateDistance(Points[0], Points[3]));
            Diameters.Add(CalculateDistance(Points[0], Points[4]));

            Diameters.Add(CalculateDistance(Points[1], Points[3]));
            Diameters.Add(CalculateDistance(Points[1], Points[4]));
            Diameters.Add(CalculateDistance(Points[1], Points[5]));

            Diameters.Add(CalculateDistance(Points[2], Points[4]));
            Diameters.Add(CalculateDistance(Points[2], Points[5]));

            Diameters.Add(CalculateDistance(Points[3], Points[5]));

        }

        public double[] GetDiametersInDescending()
        {
            return Diameters.OrderByDescending(x => x).ToArray();
        }

        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        public void Describe()
        {
            string final = $"{Name} : ";
            final += String.Format("{0:.00}", CalculatePerimeter()) + " "
                + String.Format("{0:.00}", CalculateArea())
                + " ";
            foreach (double item in GetDiametersInDescending())
            {
                final += " " + String.Format("{0:.00}", item);
            }
            Console.WriteLine(final);
        }
    }

    public class Rhombus : IShape, IShapeMoreThan4Side
    {
        private string Name { get; }
        private double Area { get; set; }
        private double Perimeter { get; set; }
        private Point Point1 { get; }
        private Point Point2 { get; }
        private Point Point3 { get; }
        private Point Point4 { get; }
        private List<double> Diameters { get; set; }
        public Rhombus(string name, string point1, string point2, string point3, string point4)
        {
            Name = name;
            Diameters = new List<double>();

            string[] inp1 = point1.Split(':');
            string[] inp2 = point2.Split(':');
            string[] inp3 = point3.Split(':');
            string[] inp4 = point4.Split(':');

            Point1 = new Point(double.Parse(inp1[0]), double.Parse(inp1[1]));
            Point2 = new Point(double.Parse(inp2[0]), double.Parse(inp2[1]));
            Point3 = new Point(double.Parse(inp3[0]), double.Parse(inp3[1]));
            Point4 = new Point(double.Parse(inp4[0]), double.Parse(inp4[1]));

            CalculateAndSaveDiameters();

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        public void Describe()
        {
            string final = $"{Name} : ";
            final += String.Format("{0:.00}", CalculatePerimeter()) + " "
                + String.Format("{0:.00}", CalculateArea())
                + " ";
            foreach (double item in GetDiametersInDescending())
            {
                final += " " + String.Format("{0:.00}", item);
            }
            Console.WriteLine(final);
        }

        private void CalculateAndSaveDiameters()
        {
            Diameters.Add(CalculateDistance(Point1, Point3));
            Diameters.Add(CalculateDistance(Point2, Point4));
        }

        public double[] GetDiametersInDescending()
        {
            return Diameters.OrderByDescending(x => x).ToArray();
        }

        public double CalculateArea()
        {
            return 0.5 * CalculateDistance(Point1, Point3) * CalculateDistance(Point2, Point4);
        }
        public double CalculatePerimeter()
        {
            return CalculateDistance(Point1, Point2)
                 + CalculateDistance(Point2, Point3)
                 + CalculateDistance(Point3, Point4)
                 + CalculateDistance(Point4, Point1);
        }

        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
    }

    public class Triangle : IShape
    {
        private string Name { get; }
        private double Area { get; set; }
        private double Perimeter { get; set; }
        private Point Point1 { get; }
        private Point Point2 { get; }
        private Point Point3 { get; }
        public Triangle(string name, string point1, string point2, string point3)
        {
            Name = name;

            string[] inp1 = point1.Split(':');
            string[] inp2 = point2.Split(':');
            string[] inp3 = point3.Split(':');

            Point1 = new Point(double.Parse(inp1[0]), double.Parse(inp1[1]));
            Point2 = new Point(double.Parse(inp2[0]), double.Parse(inp2[1]));
            Point3 = new Point(double.Parse(inp3[0]), double.Parse(inp3[1]));

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }


        public double CalculateArea()
        {
            return 0.5 * Math.Abs(
                Point1.X * (Point2.Y - Point3.Y)
                + Point2.X * (Point3.Y - Point1.Y)
                + Point3.X * (Point1.Y - Point2.Y)
                );
        }
        public double CalculatePerimeter()
        {
            return CalculateDistance(Point1, Point2)
                 + CalculateDistance(Point1, Point3)
                 + CalculateDistance(Point2, Point3);
        }
        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        public void Describe()
        {
            string final = $"{Name} : ";
            final += String.Format("{0:.00}", CalculatePerimeter()) + " "
                  + String.Format("{0:.00}", CalculateArea());
            Console.WriteLine(final);
        }
    }

    public class Square : IShape, IShapeMoreThan4Side
    {
        private string Name { get; }
        private double Area { get; set; }
        private double Perimeter { get; set; }
        private Point Point1 { get; }
        private Point Point2 { get; }
        private Point Point3 { get; }
        private Point Point4 { get; }
        private List<double> Diameters { get; set; }
        public Square(string name, string point1, string point2, string point3, string point4)
        {
            Name = name;
            Diameters = new List<double>();

            string[] inp1 = point1.Split(':');
            string[] inp2 = point2.Split(':');
            string[] inp3 = point3.Split(':');
            string[] inp4 = point4.Split(':');

            Point1 = new Point(double.Parse(inp1[0]), double.Parse(inp1[1]));
            Point2 = new Point(double.Parse(inp2[0]), double.Parse(inp2[1]));
            Point3 = new Point(double.Parse(inp3[0]), double.Parse(inp3[1]));
            Point4 = new Point(double.Parse(inp4[0]), double.Parse(inp4[1]));

            CalculateAndSaveDiameters();

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private void CalculateAndSaveDiameters()
        {
            Diameters.Add(CalculateDistance(Point1, Point3));
            Diameters.Add(CalculateDistance(Point2, Point4));
        }

        public double[] GetDiametersInDescending()
        {
            return Diameters.OrderByDescending(x => x).ToArray();
        }

        public double CalculateArea()
        {
            return CalculateDistance(Point1, Point2) * CalculateDistance(Point1, Point2);
        }
        public double CalculatePerimeter()
        {
            return 4 * CalculateDistance(Point1, Point2);
        }

        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        public void Describe()
        {
            string final = $"{Name} : ";
            final += String.Format("{0:.00}", CalculatePerimeter()) + " "
                + String.Format("{0:.00}", CalculateArea())
                + " ";
            foreach (double item in GetDiametersInDescending())
            {
                final += " " + String.Format("{0:.00}", item);
            }
            Console.WriteLine(final);
        }
    }

    public class Rectangle : IShape, IShapeMoreThan4Side
    {
        private string Name { get; }
        private double Area { get; set; }
        private double Perimeter { get; set; }
        private Point Point1 { get; }
        private Point Point2 { get; }
        private Point Point3 { get; }
        private Point Point4 { get; }
        private List<double> Diameters { get; set; }
        public Rectangle(string name, string point1, string point2, string point3, string point4)
        {
            Name = name;
            Diameters = new List<double>();

            string[] inp1 = point1.Split(':');
            string[] inp2 = point2.Split(':');
            string[] inp3 = point3.Split(':');
            string[] inp4 = point4.Split(':');

            Point1 = new Point(double.Parse(inp1[0]), double.Parse(inp1[1]));
            Point2 = new Point(double.Parse(inp2[0]), double.Parse(inp2[1]));
            Point3 = new Point(double.Parse(inp3[0]), double.Parse(inp3[1]));
            Point4 = new Point(double.Parse(inp4[0]), double.Parse(inp4[1]));

            CalculateAndSaveDiameters();

            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private void CalculateAndSaveDiameters()
        {
            Diameters.Add(CalculateDistance(Point1, Point3));
            Diameters.Add(CalculateDistance(Point2, Point4));
        }

        public double[] GetDiametersInDescending()
        {
            return Diameters.OrderByDescending(x => x).ToArray();
        }

        public double CalculateArea()
        {
            return CalculateDistance(Point1, Point2) * CalculateDistance(Point2, Point3);
        }
        public double CalculatePerimeter()
        {
            return 2 * CalculateDistance(Point1, Point2)
                 + 2 * CalculateDistance(Point2, Point3);
        }

        public void Describe()
        {
            string final = $"{Name} : ";
            final += String.Format("{0:.00}", CalculatePerimeter()) + " "
                + String.Format("{0:.00}", CalculateArea());

            foreach (double item in GetDiametersInDescending())
            {
                final += " " + String.Format("{0:.00}", item);
            }
            Console.WriteLine(final);
        }

        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public interface IShape
    {
        void Describe();
        double CalculateArea();
        double CalculatePerimeter();
    }
    public interface IShapeMoreThan4Side
    {
        double[] GetDiametersInDescending();
    }
}
