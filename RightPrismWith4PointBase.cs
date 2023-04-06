using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_F_
{
    internal class RightPrismWith4PointBase : RightTriangularPrism, ICLlabel
    {
        protected Point2D base_point4;

        public Point2D Base_point4
        {
            get { return base_point4; }
            set { base_point4 = value; }
        }

        public RightPrismWith4PointBase() : base()
        {
            base_point4 = new Point2D(0, 0);
        }

        public RightPrismWith4PointBase(Point2D base_point1, Point2D base_point2, Point2D base_point3, Point2D base_point4, double height) : base(base_point1, base_point2, base_point3, height)
        {
            this.base_point4 = base_point4;
        }


        protected override double BaseSide3
        {
            get { return Point2D.Distance(Base_point3, Base_point4); }
        }
        protected virtual double BaseSide4
        {
            get { return Point2D.Distance(Base_point4, Base_point1); }
        }

        public override double BaseArea()
        {
            double d = Point2D.Distance(Base_point1, Base_point3);

            return TriangleArea(BaseSide1, BaseSide2, d) + TriangleArea(BaseSide3, BaseSide4, d);
        }

        public override double BasePerimeter()
        {
            return BaseSide1 + BaseSide2 + BaseSide3 + BaseSide4;
        }


        public override string ToString()
        {
            return $"Точка1: ({base_point1.X}, {base_point1.Y}); точка2: ({base_point2.X}, {base_point2.Y}); точка3: ({base_point3.X}, {base_point3.Y});точка4: ({base_point4.X}, {base_point4.Y}); высотa: {height}; площадь основания: {BaseArea()}; периметр основания: {BasePerimeter()}; объем: {Volume()}; площадь боковой поверхностм: {EdgeArea()}";
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine($"Введите значение Х четвертой точки основания = ");
            base_point4.X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение Y четвертой точки основания = ");
            base_point4.Y = double.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"Прямоугольная четырехугольная призма:\nТочка1: ({base_point1.X}, {base_point1.Y})\nТочка2: ({base_point2.X}, {base_point2.Y})\nТочка3: ({base_point3.X}, {base_point3.Y})\nТочка4: ({base_point4.X}, {base_point4.Y})\nВысотa: {height}\nПлощадь основания: {BaseArea()}\nДлина основания: {BasePerimeter()}\nОбъем: {Volume()}\nПлощадь боковой поверхностм: {EdgeArea()}");
        }


        public bool IsParallelepiped()
        {
            return ((BaseSide1 == BaseSide3 & BaseSide2 == BaseSide4) & (BaseSide1 != BaseSide2 && BaseSide2 != height && height != BaseSide1));
        }

        public bool IsRightParallelepiped()
        {
            return ((BaseSide1 == BaseSide3 & BaseSide2 == BaseSide4) & (BaseSide1 == BaseSide2 || BaseSide2 == height || height == BaseSide1));
        }

        public bool IsCube()
        {
            return ((BaseSide1 == BaseSide3 & BaseSide2 == BaseSide4) & BaseSide1 == BaseSide2 && BaseSide2 == height);
        }


    }
}
