using System;
using System.Collections.Generic;
using System.Linq;


namespace _07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> countryCityPopulation = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> countryPopulation = new Dictionary<string, int>();

            while (true)
            {
                string[] inputInfo = Console.ReadLine().Split('|').ToArray();
                if (inputInfo[0].Equals("report"))
                {
                    break;
                }

                if (!countryCityPopulation.ContainsKey(inputInfo[1]))
                {
                    countryCityPopulation.Add(inputInfo[1], new Dictionary<string, int>());
                    countryCityPopulation[inputInfo[1]].Add(inputInfo[0], int.Parse(inputInfo[2]));
                }
                else
                {
                    countryCityPopulation[inputInfo[1]].Add(inputInfo[0], int.Parse(inputInfo[2]));
                }

                if (!countryPopulation.ContainsKey(inputInfo[1]))
                {
                    countryPopulation.Add(inputInfo[1], int.Parse(inputInfo[2]));
                }
                else
                {
                    countryPopulation[inputInfo[1]] += int.Parse(inputInfo[2]);
                }
            }
            Console.WriteLine();

            foreach (var item in countryCityPopulation)
            {
                foreach (var country in countryPopulation)
                {
                    if (item.Key == country.Key)
                    {
                        Console.WriteLine($"{} {}");
                        foreach (var city in item.Value)
                        {

                        }
                    }
                }
            }
            

        }
    }
}
