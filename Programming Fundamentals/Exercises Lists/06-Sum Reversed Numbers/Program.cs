using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;


            for (int i = 0; i < sequence.Count; i++)
            {

                sequence[i] = rotateNumbers(sequence[i]);

            }
            int[] result = new int[1];
            for (int i = 0; i < sequence.Count; i++)
            {
                result[0] += sequence[i];
            }

            Console.WriteLine(result[0]);
        }
        static int rotateNumbers(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;

        }
    }
}
