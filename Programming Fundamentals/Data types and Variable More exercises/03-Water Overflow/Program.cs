using System;

namespace _03_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int water = 0;

            for (int i = 0; i < n; i++)
            {
                int waterLiters = int.Parse(Console.ReadLine());

                if (water + waterLiters > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    water += waterLiters;
                }
            }
            Console.WriteLine(water);
        }
    }
}
