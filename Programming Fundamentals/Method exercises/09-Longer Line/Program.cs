using System;

namespace _09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());


            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (CheckLine(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                if (ClosedCordinate(x1,y1,x2,y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
            else
            {
                if (ClosedCordinate(x3,y3,x4,y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            CheckLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static bool CheckLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            
            int combination1 = (int)Math.Abs(x1) + (int)Math.Abs(y1) + (int)Math.Abs(x2) + (int)Math.Abs(y2);
            int combination2 = (int)Math.Abs(x3) + (int)Math.Abs(y3) + (int)Math.Abs(x4) + (int)Math.Abs(y4);

            if (combination1 >= combination2)
            {
                return true;
   
            }

            else
            {
                return false;
            }
        }
        static bool ClosedCordinate(double x1,double y1,double x2,double y2)
        {
            int cordinates1 = (int)Math.Abs(x1) + (int)Math.Abs(y1);
            int cordinates2 = (int)Math.Abs(x2) + (int)Math.Abs(y2);
            if (cordinates1 <= cordinates2)
            {
                return true;
            }
            return false;
        }
    }
}
