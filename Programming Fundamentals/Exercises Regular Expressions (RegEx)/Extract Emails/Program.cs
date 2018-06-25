using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?(?<=\s))([a-z\d]*[.-_]*[a-z\d]+)@([a-z]+[a-z.-_]*\.[a-z]+)";

            var match = Regex.Matches(input, pattern);

            foreach (var item in match)
            {
                Console.WriteLine(item);
            }
            
        }
}
}
