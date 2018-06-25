using System;

namespace Methods__Debugging_and_Troubleshooting_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintBodyReceipt();
            PrintFooterReceipt();
        }
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");

        }
        static void PrintBodyReceipt()
        {
            Console.WriteLine("Charged to\n____________________");
            Console.WriteLine("Received by\n___________________");
        }
        static void PrintFooterReceipt()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }
    }
}
