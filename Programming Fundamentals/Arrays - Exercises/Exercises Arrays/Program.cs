using System;
using System.Linq;

namespace Exercises_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] type1 = Console.ReadLine().Split(' ').ToArray();
            string[] type2 = Console.ReadLine().Split(' ').ToArray();

            int count = 0;
            int count2 = 0;
            int minValue = Math.Min(type1.Length, type2.Length);

            LargetstCommonEnd(type1, type2, ref count, ref minValue);

            string[] reversType1 = new string[type1.Length];
            string[] reversType2 = new string[type2.Length];

            int counter = 0;
            int counter2 = 0;
            for (int i = type1.Length - 1; i >= 0; i--)
            {

                reversType1[i] = type1[counter];
                counter++;
            }
            for (int i = type2.Length - 1; i >= 0; i--)
            {

                reversType2[i] = type2[counter2];
                counter2++;
            }

            count2 += LargestReversCommonEnd(reversType1, reversType2, count, minValue);

            if (count > 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count2);
            }
                
            
        }

        private static int LargetstCommonEnd(string[] type1, string[] type2, ref int count, ref int minValue)
        {
            for (int i = 0; i < minValue; i++)
            {

                if (type1[i] == type2[i])
                {
                    count++;
                }
            }
            return count;
        }
        static int LargestReversCommonEnd(string[] reversType1, string[] reversType2, int count, int minValue)
        {
            
            for (int i = 0; i < minValue; i++)
            {

                if (reversType1[i] == reversType2[i])
                {
                    count++;
                }
            }
            return count;
        }
    }

}
