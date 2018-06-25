using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Max_Sequence_of_Equal_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] equalElements = new int[numbers.Capacity];

            int start = 0;
            int printFrom = start;

            int maxEqualNums = 1;
            int index = 0;
            int count = 1;

            for (int i = 1; i < numbers.Capacity; i++)
            {

                if (numbers[i] != numbers[i-1] )
                {
                    start = i;
                }

                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxEqualNums)
                {
                    printFrom = start;
                    maxEqualNums = count;
                    index = i;
                }

            }

            Console.Write(numbers[printFrom]);
            for (int i = printFrom+1; i <= index; i++)
            {
                Console.Write(", "+numbers[i]);
            }
        }
    }
}
