using System;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
        static long Fib (long n)
        {
            long fa = 0;
            long fb = 1;
            long fSum = 0;

            if (n == 0)
            {
                return 1;
            }
            for (long i = 1; i <= n; i++)
            {
                fSum = fa + fb;
                fa = fb;
                fb = fSum;
            }
            return fSum;

        }
    }
}
