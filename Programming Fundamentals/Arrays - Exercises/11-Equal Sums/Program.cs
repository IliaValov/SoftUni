using System;
using System.Linq;

namespace _11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSideNumbers = 1;

            int leftSideSum = 0;
            int rightSideSum = 0;

            int result = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSideSum = 0;
                for (int k = 0; k < leftSideNumbers; k++)
                {
                    leftSideSum += numbers[k];
                }
                rightSideSum = 0;

                for (int j = i+2; j < numbers.Length; j++)
                {
                    rightSideSum += numbers[j];
                }
                

                if (leftSideSum == rightSideSum)
                {
                    result = i+1;
                    break;
                }
                leftSideNumbers++;
                if (leftSideNumbers > numbers.Length-1)
                {
                    break;
                }
                

            }
            if (numbers[0] == 0 && numbers[numbers.Length-1] == 0)
            {
                Console.WriteLine(0);
                return;
            }
            
            if (result >= 1)
            {
                Console.WriteLine(result);
            }
            else if(numbers[numbers.Length-1] == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
