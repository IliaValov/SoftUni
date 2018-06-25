using System;

namespace _03_Practice_Characters_and_Strings
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
