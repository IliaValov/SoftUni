using System;

namespace Data_types_and_Variable_More_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            sbyte minValue = sbyte.MinValue;
            sbyte maxValue = sbyte.MaxValue;

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;

            ushort ushortMinValue = ushort.MinValue;
            ushort ushortMaxValue = ushort.MaxValue;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            uint uintMinValue = uint.MinValue;
            uint uintMaxValue = uint.MaxValue;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;

            ulong ulongMinValue = ulong.MinValue;
            ulong ulongMaxValue = ulong.MaxValue;

            switch (type)
            {
                case "sbyte":
                    Console.WriteLine($"{maxValue}\n{minValue}");
                    break;
                case "byte":
                    Console.WriteLine($"{byteMaxValue}\n{byteMinValue}");
                    break;


                case "short":
                    Console.WriteLine($"{shortMaxValue}\n{shortMinValue}");
                    break;
                case "ushort":
                    Console.WriteLine($"{ushortMaxValue}\n{ushortMinValue}");
                    break;


                case "int":
                    Console.WriteLine($"{intMaxValue}\n{intMinValue}");
                    break;
                case "uint":
                    Console.WriteLine($"{uintMinValue}\n{uintMaxValue}");
                    break;


                case "long":
                    Console.WriteLine($"{longMaxValue}\n{longMinValue}");
                    break;
                case "ulong":
                    Console.WriteLine($"{ulongMaxValue}\n{ulongMinValue}");
                    break;
            }
        }
    }
}
