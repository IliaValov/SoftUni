using System;

namespace _07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            int c = b;
            int d = a;

            a = c;
            b = d;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
