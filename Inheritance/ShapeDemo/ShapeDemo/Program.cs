using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(2.0,"Red");
            Shape rectangle = new Rectangle(6,4,"Green");
            Shape triangle = new Triangle(3,4,5,"Yellow");

            Console.WriteLine(circle.Color);
            Console.WriteLine(rectangle.getCircum());
            Console.WriteLine(circle.GetArea());
        }
    }
    abstract class Shape
    {
        private string color;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public virtual double GetArea()
        {
            return 1;
        }
        public abstract double getCircum();
    }

    class Triangle:Shape
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double side1, double side2, double side3, string color)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            Color = color;
        }

        public override double getCircum()
        {
            return side1 + side2 + side3;
        }
    }
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius,string color)
        {
            this.radius = radius;
            Color = color;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double getCircum()
        {
            return 2 * Math.PI * radius;
        }
    }
    class Rectangle : Shape
    {
        double length;
        double width;
        public Rectangle(double length, double width, string color)
        {
            this.length = length;
            this.width = width;
            Color = color;
        }

        public override double getCircum()
        {
            return 2 * (length + width);
        }
    }

}
