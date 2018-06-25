using System;
using System.Linq;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequence = 0;
            int start = 0 ;
            int start2 = numbers[1];
            int num = numbers[0];
            int repeated = 1;
            int index = numbers[0];


            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] - numbers[i - 1] < 1)
                {
                    start = i;
                    repeated = 1;
                }
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    repeated++;
                    if (repeated > maxSequence)
                    {
                        maxSequence = repeated;
                        num = numbers[i];
                        start2 = start;
                        index = i;
                    }
                }
            }
            for (int i = start2; i <= index; i++)
            {
                Console.Write(numbers[i]+" ");
            }
           
        }
    }
}
