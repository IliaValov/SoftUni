using System;
using System.Linq;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long rotates = long.Parse(Console.ReadLine());

            //if (rotates >= 1)
            //{
            long[] firstRotate = new long[numbers.Length];
            for (long i = 0; i <= numbers.Length - 1; i++)
            {
                firstRotate[i] = numbers[i];
            }

            firstRotate = RotateArray(firstRotate);
            long[] sum = new long[firstRotate.Length];
            for (long i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRotate[i];
            }

            for (long i = 0; i < rotates - 1; i++)
            {
                firstRotate = RotateArray(firstRotate);
                sum = GetSum(sum, firstRotate);
            }

            for (long i = 0; i <= sum.Length - 1; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
        //}

        private static long[] RotateArray(long[] firstRotate)
        {
            long[] rotateArray = new long[firstRotate.Length];
            if (firstRotate.Length <= 1)
            {
                return firstRotate;
            }
            //Last symbol is going to index 0
            rotateArray[0] = firstRotate[firstRotate.Length - 1];

            rotateArray[rotateArray.Length - 1] = firstRotate[firstRotate.Length - 2];

            for (long i = 1; i <= firstRotate.Length - 2; i++)
            {
                rotateArray[i] = firstRotate[i - 1];

            }
            return rotateArray;
        }
        static long[] GetSum(long[] sum, long[] firstRotate)
        {

            for (long i = 0; i < sum.Length; i++)
            {
                sum[i] += firstRotate[i];
            }
            return sum;
        }
    }
}
