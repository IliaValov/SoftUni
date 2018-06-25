using System;

namespace SqureRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SqureRoot(5));
            Console.WriteLine(Math.Sqrt(5));
        }
        static double SqureRoot(double num)
        {
            double result = 0.0;
            for (double i = 2; i <= 10; i+=0.1)
            {
                double currentResult = i * i;
                if (currentResult == num)
                {
                    result = i;
                }
               

            }
            return result;
        }
    }
}
