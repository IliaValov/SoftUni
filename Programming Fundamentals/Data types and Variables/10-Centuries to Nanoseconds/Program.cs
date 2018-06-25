using System;
using System.Numerics;

namespace _10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            long minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            BigInteger = 5;

        }
    }
}
