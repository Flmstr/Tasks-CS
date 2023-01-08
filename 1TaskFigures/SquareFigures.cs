using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SquareFiguresTest")]

namespace SquareFigures
{
    public abstract class Figure
    {
        public abstract double Square();
    }

    public class Triangle : Figure
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a == 0 | b == 0 | c == 0)
            {
                throw new Exception("Сторона не может быть меньше или равнен 0");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public override double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool Rectangular()
        {
            if (Math.Pow(a,2) == Math.Pow(b, 2) + Math.Pow(c, 2)
                | Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)
                | Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class Circle : Figure
    {
        double r;

        public Circle(double r)
        {
            
            if (r == 0)
            {
                throw new Exception("Радиус не может быть меньше или равен 0");
            }
            else
            {
                this.r = r;
            }
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }
}
