using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();


            while (true)
            {
                Dictionary<string, int> ipCount = new Dictionary<string, int>();
                string[] logsInfo = Console.ReadLine().Split('=', ' ', '\'').ToArray();
                if (logsInfo[0].Equals("end"))
                {
                    break;
                }
                string ip = logsInfo[1];
                string name = logsInfo[logsInfo.Length - 1];
                int count = 0;


                if (!userLogs.ContainsKey(name))
                {
                    count++;
                    ipCount.Add(ip, count);
                    userLogs.Add(name, ipCount);

                }
                else if (userLogs.ContainsKey(name))
                {

                    if (!userLogs[name].ContainsKey(ip))
                    {
                        count++;
                        userLogs[name].Add(ip, count);
                    }
                    else if (userLogs[name].ContainsKey(ip))
                    {
                        count++;
                        userLogs[name][ip] += count;
                    }
                }

            }



            foreach (var item in userLogs)
            {
                List<string> addinDots = new List<string>();
                Console.WriteLine($"{item.Key}: ");
                foreach (var innerItem in item.Value)
                {
                    addinDots.Add($"{innerItem.Key} => {innerItem.Value}");
                }
                Console.WriteLine(string.Join(", ", addinDots + "."));
            }
        }
    }
}

