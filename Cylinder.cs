using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_F_
{
    internal class Cylinder : ICLlabel
    {
        protected Point2D base_point1;
        protected Point2D base_point2;
        protected double height;


        public Cylinder()
        {
            base_point1 = new Point2D(0, 0);
            base_point2 = new Point2D(0, 0);
            height = 0;
        }

        public Cylinder(Point2D center, Point2D pointOnCircle, double height)
        {
            base_point1 = center;
            base_point2 = pointOnCircle;
            this.height = height;
        }


        public Point2D Base_point1
        {
            get { return base_point1; }
            set { base_point1 = value; }
        }

        public Point2D Base_point2
        {
            get { return base_point2; }
            set { base_point2 = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public virtual double BaseArea()
        {
            double r = Point2D.Distance(base_point1, base_point2);
            return Math.PI * r * r;
        }


        public virtual double BasePerimeter()
        {
            double r = Point2D.Distance(base_point1, base_point2);
            return 2 * Math.PI * r;
        }

        public double Volume()
        {
            return BaseArea() * height;
        }

        public double EdgeArea()
        {
            return BasePerimeter() * height;
        }



        public override string ToString()
        {
            return $"Центр в точке ({base_point1.X}, {base_point1.Y}); точка на окружности: ({base_point2.X}, {base_point2.Y}); высотa: {height}; площадь основания: {BaseArea()}; длина основания: {BasePerimeter()}; объем: {Volume()}; площадь боковой поверхностм: {EdgeArea()}";
        }


        public virtual void Input()
        {
            Console.WriteLine("Вводите точки поочередно в направлении по часовой стрелке!");
            Console.WriteLine($"Введите значение Х первой точки основания = ");
            base_point1.X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение Y первой точки основания = ");
            base_point1.Y = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение Х второй точки основания = ");
            base_point2.X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите значение Y второй точки основания = ");
            base_point2.Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту фигуры = ");
            height = double.Parse(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine($"Цилиндр:\nЦентр в точке: ({base_point1.X}, {base_point1.Y})\nТочка на окружности: ({base_point2.X}, {base_point2.Y})\nВысотa: {height}\nПлощадь основания: {BaseArea()}\nДлина основания: {BasePerimeter()}\nОбъем: {Volume()}\nПлощадь боковой поверхностм: {EdgeArea()}");
        }


    }


}
