using System;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double sum = 0;
            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    sum = Triangle(side,height);
                    break;
                case "square":
                    double SquareSide = double.Parse(Console.ReadLine());
                    sum = Square(SquareSide);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    sum = Rectangle(width, rectangleHeight);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    sum = Circle(radius);
                    break;
            }
            Console.WriteLine($"{sum:F2}");
        }
        static double Square(double number)
        {
            double square = number * number;
            return square;
        }
        static double Rectangle(double width,double height)
        {
            double rectangle = width * height;
            return rectangle;
        }
        static double Triangle(double side, double height)
        {
            double triangle = 0.5*side*height;
            return triangle;
        }
        static double Circle(double radius)
        {
            double circle = Math.PI * (radius * radius);
            return circle;
        }
    }
}
