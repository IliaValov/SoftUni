using System;
using System.Collections.Generic;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mining = new Dictionary<string, int>();


            while (true)
            {

                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int value = int.Parse(Console.ReadLine());

                if (mining.ContainsKey(resource))
                {
                    mining[resource] += value;
                }
                else
                {

                    mining.Add(resource, value);
                }

            }
            foreach (var item in mining)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
