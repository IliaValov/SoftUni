using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isValid = false;
            List<int> arr = new List<int>();
            int index1 = numbers[0];
            int index2 = numbers[1];



            for (int i = 0; i < sequence.Count; i++)
            {
                arr.Add(sequence[i]);

            }
            for (int j = 0; j < index2; j++)
            {
                arr.RemoveAt(0);
            }


            for (int i = 0; i < arr.Count; i++)
            {



                if (numbers[2] == arr[i])
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
