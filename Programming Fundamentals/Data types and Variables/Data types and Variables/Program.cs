using System;

namespace Data_types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = sbyte.Parse(Console.ReadLine());
            
            byte num2 = byte.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            ushort num4 = ushort.Parse(Console.ReadLine());
            uint num5 = uint.Parse(Console.ReadLine());
            long num6 = long.Parse(Console.ReadLine());
            decimal num7 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}\n{num5}\n{num6}\n{num7}");
        } 
    }
}

