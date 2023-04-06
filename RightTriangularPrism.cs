using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_F_
{
    internal class RightTriangularPrism : Cylinder, ICLlabel
    {
        protected Point2D base_point3;


        public Point2D Base_point3
        {
            get { return base_point3; }
            set { base_point1 = value; }
        }


        public RightTriangularPrism() : base()
        {
            base_point3 = new Point2D(0, 0);
        }

        public RightTriangularPrism(Point2D base_point1, Point2D base_point2, Point2D base_point3, double height) : base(base_point1, base_point2, height)
        {
            this.base_point3 = base_point3;
        }

        protected virtual double BaseSide1
        {
            get { return Point2D.Distance(Base_point1, Base_point2); }
        }

        protected virtual double BaseSide2
        {
            get { return Point2D.Distance(Base_point2, Base_point3); }
        }

        protected virtual double BaseSide3
        {
            get { return Point2D.Distance(Base_point3, Base_point1); }
        }


        static protected double TriangleArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Abs(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)));
        }


        public override double BaseArea()
        {
            return TriangleArea(BaseSide1, BaseSide2, BaseSide3);
        }

        public override double BasePerimeter()
        {
            return BaseSide1 + BaseSide2 + BaseSide3;
        }


        public override string ToString()
        {
            return $"Точка1: ({base_point1.X}, {base_point1.Y}); точка2: ({base_point2.X}, {base_point2.Y}); точка3: ({base_point3.X}, {base_point3.Y}); высотa: {height}; площадь основания: {BaseArea()}; периметр основания: {BasePerimeter()}; объем: {Volume()}; площадь боковой поверхностм: {EdgeArea()}";
        }


        public override void Input()
        {
            base.Input();
            Console.WriteLine($"Введите значение Х третьей точки основания = ");
            base_point3.X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение Y третьей точки основания = ");
            base_point3.Y = double.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"Прямоугольная треугольная призма:\nТочка1: ({base_point1.X}, {base_point1.Y})\nТочка2: ({base_point2.X}, {base_point2.Y})\nТочка3: ({base_point3.X}, {base_point3.Y})\nВысотa: {height}\nПлощадь основания: {BaseArea()}\nДлина основания: {BasePerimeter()}\nОбъем: {Volume()}\nПлощадь боковой поверхностм: {EdgeArea()}");
        }


    }
}
