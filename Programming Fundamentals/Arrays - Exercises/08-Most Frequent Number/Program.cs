using System;
using System.Linq;

namespace _08_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long repeated = 1;
            long mostRepeated = 1;
            long number = 0;

            for (long i = 0; i < numbers.Length; i++)
            {
                repeated = 1;
                for (long j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        repeated++;
                        if (repeated > mostRepeated)
                        {
                            mostRepeated = repeated;
                            number = numbers[i];
                        }
                    }
                }

                
            }
            Console.WriteLine($"{number}");
        }
    }
}
