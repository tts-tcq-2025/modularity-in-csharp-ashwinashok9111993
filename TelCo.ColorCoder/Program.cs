using System;

namespace TelCo.ColorCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("25-Pair Color Code Reference Manual:");
            ReferenceManualPrinter.PrintReferenceManual(Console.WriteLine);
        }
    }
}
