using System;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverserOrder(number);

        }
        static void ReverserOrder(string num)
        {


            string result = "";
            char symbol;
            
            for (int i = num.Length - 1; i >= 0; i--)
            {
                symbol = num[i];
                result += symbol;

            }
            Console.WriteLine(result);


        }
    }
}

