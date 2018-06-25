using System;
using System.Linq;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstWord = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondWord = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int index = firstWord.Length;
            int index2 = secondWord.Length;

            int getMinValue = Math.Min(index, index2);
            bool isValidFirstWord = false;
            bool isValidSecondWord = false;

            for (int i = 0; i < getMinValue; i++)
            {
                if (firstWord[i] < secondWord[i])
                {
                    isValidFirstWord = true;
                    break;
                }

                for (int j = 0; j < getMinValue; j++)
                {
                    if (secondWord[j] < firstWord[j])
                    {
                        isValidSecondWord = true;
                        break;
                    }
                }
                if (isValidSecondWord)
                {
                    break;
                }
            }


            if (isValidFirstWord)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    Console.Write(firstWord[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < secondWord.Length; i++)
                {
                    Console.Write(secondWord[i]);

                }
            }
            else
            {
                if (index < index2)
                {
                    for (int j = 0; j < firstWord.Length; j++)
                    {
                        Console.Write(firstWord[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < secondWord.Length; j++)
                    {
                        Console.Write(secondWord[j]);

                    }
                }
                else if (index2 < index)
                {
                    for (int i = 0; i < secondWord.Length; i++)
                    {
                        Console.Write(secondWord[i]);

                    }
                    Console.WriteLine();
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        Console.Write(firstWord[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < secondWord.Length; i++)
                    {
                        Console.Write(secondWord[i]);

                    }
                    Console.WriteLine();
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        Console.Write(firstWord[i]);
                    }
                }
            }
        }


    }
}

