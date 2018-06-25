using System;

namespace _15_Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNumber = int.Parse(Console.ReadLine());
            for (int row = 2; row <= enterNumber; row++)
            {
                bool itIsTrue = true;
                for (int CheckNumber = 2; CheckNumber <= Math.Sqrt(row); CheckNumber++)
                {
                    if (row % CheckNumber == 0)
                    {
                        itIsTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{row} -> {itIsTrue}");
            }

        }
    }
}
