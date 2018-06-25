using System;
using System.Numerics;

namespace _13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
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
    }
}
