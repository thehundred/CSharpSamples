using System;
using System.Collections.Generic;

namespace Sample_1
{
    struct Point
    {
        public int X { set; get; }
        public int Y { set; get; }

        public List<string> Tags;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Tags = new List<string>();
        }

        public override string ToString()
        {
            return $"({X}, {Y}), Tags {string.Join(",",Tags)}";
        }

        public void AddToTags(string tag) { Tags.Add(tag); }
    }

    class Program
    {
        static void ChangePoint(Point p, int val)
        {
            p.X = val;
            Console.WriteLine($"Point1 inside changepoint method is {p}");
        }

        static void Main(string[] args)
        {
            Point point1 = new Point(3,5);
            Point point2 = point1;
            point2.Y = 14;
            point2.AddToTags("Hello");

            Console.WriteLine($"Point1 is {point1}");
            Console.WriteLine($"Point2 after changing point1 is {point2}");

            ChangePoint(point1, 10);
            Console.WriteLine($"Point1 after changepoint method call is {point1}");
        }
    }
}
