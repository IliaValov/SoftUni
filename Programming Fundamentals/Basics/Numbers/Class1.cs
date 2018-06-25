using System;

namespace Numbers
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i < number2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
