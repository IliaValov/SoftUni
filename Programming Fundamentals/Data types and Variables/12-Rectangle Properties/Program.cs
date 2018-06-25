using System;

namespace _12_Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            
            double rectanglePerimeter = 2 * (width + heigth);
            double rectangleArea = width * heigth;
            double rectangleDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(heigth, 2));

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
