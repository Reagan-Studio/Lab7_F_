using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_F_
{
    internal class Point2D : ICLlabel
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point2D() { }
        public Point2D(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        public void Input()
        {
            Console.WriteLine($"Введите значение Х = ");
            X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение Y = ");
            Y = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Значение Х точки = {X}");
            Console.WriteLine($"Значение Y точки = {Y}");
        }

        static public double Distance(Point2D start_point, Point2D end_point)
        {
            return Math.Abs(Math.Sqrt((end_point.X - start_point.X) * (end_point.X - start_point.X) + (end_point.Y - start_point.Y) * (end_point.Y - start_point.Y)));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
