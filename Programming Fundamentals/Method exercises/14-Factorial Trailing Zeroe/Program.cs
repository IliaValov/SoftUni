using System;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroe
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(n);
            Console.WriteLine(TrailingZeroes(factorial));
        }
        static BigInteger Factorial(BigInteger n)
        {
            BigInteger sum = 1;
            for (BigInteger i = n; i >= 1; i--)
            {
                sum *= i;
            }
            return sum;
        }
        static BigInteger TrailingZeroes(BigInteger n)
        {
            BigInteger sum = 0;
            while(true)
            {
                if (n % 10 == 0)
                {
                    sum++;
                }
                else
                {
                    return sum;
                }
                n /= 10;
            }
        }
    }
}
