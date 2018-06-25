using System;
using System.Numerics;

namespace _18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool itsCapable = false;
            string print = "";

            try
            {
                sbyte ssbyte = sbyte.Parse(num);
                itsCapable = true;
                print += "* sbyte\n";
            }
            catch(Exception)
            {

            }
            try
            {
                byte bytte = byte.Parse(num);
                itsCapable = true;
                print += "* byte\n";
            }
            catch (Exception)
            {

            }
            try
            {
                short shortt = short.Parse(num);
                itsCapable = true;
                print += "* short\n";
            }
            catch (Exception)
            {

            }
            try
            {
                ushort uushort = ushort.Parse(num);
                itsCapable = true;
                print += "* ushort\n";
            }
            catch (Exception)
            {

            }
            try
            {
                int integer = int.Parse(num);
                itsCapable = true;
                print += "* int\n";
            }
            catch (Exception)
            {

            }
            try
            {
                uint uinteger = uint.Parse(num);
                itsCapable = true;
                print += "* uint\n";
            }
            catch (Exception)
            {

            }
            try
            {
                long longg = long.Parse(num);
                itsCapable = true;
                print += "* long\n";
            }
            catch (Exception)
            {

            }
            
            if (itsCapable == true)
            {
                Console.WriteLine($"{num} can fit in:\n{print}");
            }
            else
            {
                Console.WriteLine($"{num} can't fit in any type");
            }

            
        }
    }
}
