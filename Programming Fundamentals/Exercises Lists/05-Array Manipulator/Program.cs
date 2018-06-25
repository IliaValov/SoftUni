using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool print = true;

            while (print)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0].Equals("print"))
                {                  
                    break;
                }
                if (commands[0].Equals("add"))
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);

                    sequence.Insert(index, element);
                }
                else if (commands[0].Equals("addMany"))
                {
                    int index = int.Parse(commands[1]);

                    for (int i = commands.Count-1; i >= 2; i--)
                    {
                        int element = int.Parse(commands[i]);
                        sequence.Insert(index, element);


                    }
                }
                else if (commands[0].Equals("contains"))
                {
                    bool isValid = false;
                    int index = 0;
                    int element = int.Parse(commands[1]);
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (element == sequence[i])
                        {
                            Console.WriteLine(i);
                            isValid = true;
                        }
                    }
                    if (isValid)
                    {

                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commands[0].Equals("remove"))
                {
                    int index = int.Parse(commands[1]);

                    sequence.RemoveAt(index);
                }
                else if (commands[0].Equals("shift"))
                {
                    int index = int.Parse(commands[1]);
                    int[] arr = new int[sequence.Count];
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        arr[i] = sequence[i];
                    }

                    for (int i = 0; i < index; i++)
                    {
                        arr = RotateArray(arr);
                    }
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sequence[i] = arr[i];
                    }
                }
                else if (commands[0].Equals("sumPairs"))
                {
                    sequence = SumList(sequence);
                }
                

            }

            Console.WriteLine("["+string.Join(", ", sequence)+"]");



        }
        static int[] RotateArray(int[] array)
        {
            int[] array2 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            array2[array2.Length - 1] = array[0];
            array2[0] = array[1];

            for (int i = array2.Length - 2; i >= 0; i--)
            {
                array2[i] = array[i + 1];
            }
            return array2;

        }
        static List<int> SumList(List<int> list)
        {

            List<int> result = new List<int>();
            int[] sumList = new int[list.Count / 2];


            for (int i = 0; i < sumList.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    sumList[i] = list[j] + list[j + 1];
                    list.RemoveAt(0);
                    list.RemoveAt(0);
                }

            }

            result.AddRange(sumList);

            return result;
        }
    }
}
