using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, string>> weather = new Dictionary<string, Dictionary<double, string>>();
            SortedDictionary<double, Dictionary<string, string>> sortedWeather = new SortedDictionary<double, Dictionary<string, string>>();

            string pattern = @"([A-Z]{2})(\d+.\d+)([A-Za-z]+)(\|)";
            string input = Console.ReadLine();
            while (input != "end")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    if (!weather.ContainsKey(match.Groups[1].Value))
                    {
                        weather.Add(match.Groups[1].Value, new Dictionary<double, string>());
                        weather[match.Groups[1].Value].Add(double.Parse(match.Groups[2].Value), match.Groups[3].Value);
                    }
                    else if (weather.ContainsKey(match.Groups[1].Value))
                    {
                        weather.Remove(match.Groups[1].Value);
                        weather.Add(match.Groups[1].Value, new Dictionary<double, string>());
                        weather[match.Groups[1].Value].Add(double.Parse(match.Groups[2].Value), match.Groups[3].Value);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in weather)
            {
                foreach (var innerItem in item.Value.OrderBy(e => e.Key))
                {
                    sortedWeather.Add(innerItem.Key, new Dictionary<string, string>());
                    sortedWeather[innerItem.Key].Add(item.Key, innerItem.Value);
                }
            }

            foreach (var item in sortedWeather)
            {

                foreach (var innerItem in item.Value)
                {
                    Console.WriteLine($"{innerItem.Key} => {item.Key} => {innerItem.Value}");
                }
            }

        }
    }
}
