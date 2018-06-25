using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05_Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] replacer = Console.ReadLine().Split('<', '|', '\\', '/').ToArray();
            string input = Console.ReadLine();

            string pattern = $@"{replacer[0]}(.*?){replacer[2]}";

            MatchCollection match = Regex.Matches(input, pattern);


            if (Regex.IsMatches(input, pattern))
            {
                foreach (Match matches in match)
                {
                    if (matches.Success)
                    {
                        Console.Write(string.Join("", matches.Groups[1].Value));
                    }
                }
            }
            else
            {
                Console.WriteLine("Empty result");
            }

        }
    }

}
