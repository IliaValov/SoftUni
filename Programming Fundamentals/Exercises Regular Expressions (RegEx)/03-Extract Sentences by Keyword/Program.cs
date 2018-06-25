using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Regex.Split(Console.ReadLine(), "\\s+").Select(x => int.Parse(x)).ToArray();

            string input = Console.ReadLine();

            string pattern = $@"\|<.{{{numbers[0]}}}([^\|]{{0,{numbers[1]}}})";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            List<string> result = new List<string>();
            foreach(Match item in matches)
            {
                result.Add(item.Groups[1].Value);
            }

            
            Console.WriteLine(string.Join(", ",result));





        }
    }
}
