using System;
using System.Linq;

namespace _09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] alphaBets = word.ToCharArray();

            for (int i = 0; i < alphaBets.Length; i++)
            {
                Console.WriteLine($"{(char)alphaBets[i]} -> {alphaBets[i] - 97}");
            }
        }
    }
}
