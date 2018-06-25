using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[1];

            int bombNumber = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (bombNumbers[0] == sequence[i])
                {
                    bombNumber = i;
                    for (int j = 0; j < bombNumbers[1]; j++)
                    {

                        if (bombNumber + 1 < sequence.Count)
                        {
                            sequence.RemoveAt(bombNumber + 1);
                        }
                        if (bombNumber - 1 >= 0)
                        {
                            sequence.RemoveAt(bombNumber - 1);
                            bombNumber--;
                        }
                    }
                    sequence.RemoveAt(bombNumber);
                    i = -1;

                }
            }

            foreach (var number in sequence)
            {
                result[0] += number;
            }

            Console.WriteLine(result[0]);
        }
    }
}

