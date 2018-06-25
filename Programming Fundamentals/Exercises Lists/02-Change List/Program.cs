using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool odd = false;
            bool even = false;
            bool print = true;

            int numberForDelete = 0;
            int numberForInsert = 0;
            int numberForInsert2 = 0;

            int index = sequence.Count;


            while (print)
            {
                string[] inputMethod = Console.ReadLine().Split().ToArray();

                string method = inputMethod[0];

                if (inputMethod.Length == 2)
                {
                    numberForDelete = int.Parse(inputMethod[1]);
                }


                if (inputMethod.Length == 3)
                {
                    numberForInsert = int.Parse(inputMethod[1]);
                    numberForInsert2 = int.Parse(inputMethod[2]);
                }


                switch (method)
                {
                    case "Delete":
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            sequence.Remove(numberForDelete);
                        }

                        break;
                    case "Insert":
                        sequence.Insert(numberForInsert2, numberForInsert);

                        break;
                    case "Odd":
                        odd = true;
                        print = false;
                        break;
                    case "Even":
                        print = false;
                        even = true;
                        break;
                }
            }

            if (odd)
            {

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] % 2 != 0)
                    {
                        Console.Write(sequence[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] % 2 == 0)
                    {
                        Console.Write(sequence[i] + " ");
                    }
                }
            }

        }
    }
}
