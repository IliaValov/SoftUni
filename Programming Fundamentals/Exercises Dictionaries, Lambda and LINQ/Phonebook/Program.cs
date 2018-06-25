using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();




            while (true)
            {

                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0].Equals("A"))
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook[input[1]] = input[2];
                    }
                    else
                    {

                        phoneBook.Add(input[1], input[2]);
                    }
                }
                else if (input[0].Equals("S"))
                {


                    if (phoneBook.ContainsKey(input[1]))
                    {

                        Console.WriteLine($"{input[1]} -> {phoneBook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if(input[0].Equals("ListAll"))
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                else
                {
                    return;
                }
            }

        }
    }
}
