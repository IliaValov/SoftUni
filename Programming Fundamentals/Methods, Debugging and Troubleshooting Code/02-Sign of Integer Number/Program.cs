using System;

namespace _02_Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintDashes(n);
            PrintMiddleRow(n);
            PrintDashes(n);
            
        }
        static void PrintDashes(int n)
        {
            for (int i = 0; i < n*2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n-2; i++)
            {

                Console.WriteLine("-{0}-",repeat("\\/", n - 1));
            }
        }
        static string repeat(string symbol,int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += symbol;
            }
            return result;
            
        }

    }
}
