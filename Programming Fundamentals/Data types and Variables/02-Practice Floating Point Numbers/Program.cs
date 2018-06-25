using System;

namespace _02_Practice_Floating_Point_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = decimal.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{num1}\n{num2}\n{num3}");
        }
    }
}
