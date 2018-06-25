using System;

namespace _06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(long n)
        {
            
            bool isPrime = true;

            long num = (long)Math.Sqrt(n);

            if(n <= 1)
            {
                return false;
            }
            else if(n > 2)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
