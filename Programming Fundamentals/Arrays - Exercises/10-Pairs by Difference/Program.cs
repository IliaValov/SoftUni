using System;
using System.Linq;

namespace _10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int repeated = 0;
            int maxRepeated = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + diff == numbers[j])
                    {
                        repeated++;
                        if (repeated > maxRepeated)
                        {
                            maxRepeated = repeated;
                        }
                    }
                }
            }
            Console.WriteLine(maxRepeated);

        }
    }
}
