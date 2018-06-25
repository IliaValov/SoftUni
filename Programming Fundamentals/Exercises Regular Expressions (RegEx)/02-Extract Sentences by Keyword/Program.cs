using System;
using System.Text.RegularExpressions;

namespace _02_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"[^!.?]*?\b({word})\b.*?(?=[!?.])";

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match item in match)
            {
                Console.WriteLine(item.Groups[0].Value.Trim());
            }
        }
    }
}
