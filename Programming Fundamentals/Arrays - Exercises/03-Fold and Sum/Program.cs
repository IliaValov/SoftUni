using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = numbers.Length/2;

            int indexForRotate = 0;

            int[] rotateNum1 = new int[index];
            int[] rotateNum2 = new int[index];

            int[] rotateLeft = new int[numbers.Length / 4];
            int[] rotateRight = new int[numbers.Length / 4];

            int[] rotateLeft2 = new int[numbers.Length / 4];
            int[] rotateRight2 = new int[numbers.Length / 4];



            //Left
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                rotateNum1[i] = numbers[i];
            }

            for (int i = 0; i < index/2; i++)
            {
                rotateLeft[i] = rotateNum1[i];
            }
            int counter = 0;
            for (int i = rotateNum1.Length - 1; i >= index/2; i--)
            {
                rotateRight[counter] = rotateNum1[i];
                counter++;
            }

            //Right
            for (int i = numbers.Length - 1; i >= numbers.Length / 2; i--)
            {
                rotateNum2[indexForRotate] = numbers[i];
                indexForRotate++;
            }

            for (int i = 0; i < index / 2; i++)
            {
                rotateLeft2[i] = rotateNum2[i];
            }
            int counter2 = 0;
            for (int i = rotateNum2.Length - 1; i >= index/2; i--)
            {
                rotateRight2[counter2] = rotateNum2[i];
                counter2++;
            }


            int count1 = 0;
            int count2 = 0;

            for (int i = numbers.Length / 4 - 1; i >= 0; i--)
            {
                Console.Write(rotateLeft[i] + rotateRight[i]+" ");
            }
            
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                Console.Write(rotateLeft2[i] + rotateRight2[i]+ " ");
            }


        }
    }
}
