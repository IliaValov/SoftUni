using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<string, string> encryptions = new SortedDictionary<string, string>();
        string numbers = Console.ReadLine();
        string pattern = @"TO: ([A-Z]+); MESSAGE: .*;";



        string input = Console.ReadLine();
        while (input != "END")
        {
            char symbol;
            char[] text = input.ToCharArray();

            string encryption = "";


            if (Regex.IsMatch(input, pattern))
            {
                Match match = Regex.Match(input, pattern);
                for (int i = 0; i < text.Length; i++)
                {
                    int num = text[i];
                    num += int.Parse(numbers[i % numbers.Length].ToString());
                    symbol = (char)num;
                    encryption += symbol;

                }
                encryptions.Add(match.Groups[1].Value, encryption);
            }
            input = Console.ReadLine();
        }

        foreach (var item in encryptions)
        {
            Console.WriteLine(item.Value);
        }
    }

}

