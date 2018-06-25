using System;
using System.Collections.Generic;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                emails.Add(name, email);
            }            

            foreach (var item in emails)
            {
                if (item.Value.EndsWith("us") || item.Value.EndsWith("co"))
                {

                }
                else
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }


            }

        }

    }
}

