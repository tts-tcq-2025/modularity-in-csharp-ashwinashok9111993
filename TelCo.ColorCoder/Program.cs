using System;
using TelCo.ColorCoder;

namespace TelCo.ColorCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairNumber = 4;
            var testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            System.Diagnostics.Debug.Assert(testPair1.MajorColor == System.Drawing.Color.White);
            System.Diagnostics.Debug.Assert(testPair1.MinorColor == System.Drawing.Color.Brown);

            pairNumber = 5;
            testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            System.Diagnostics.Debug.Assert(testPair1.MajorColor == System.Drawing.Color.White);
            System.Diagnostics.Debug.Assert(testPair1.MinorColor == System.Drawing.Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            System.Diagnostics.Debug.Assert(testPair1.MajorColor == System.Drawing.Color.Violet);
            System.Diagnostics.Debug.Assert(testPair1.MinorColor == System.Drawing.Color.Green);

            var testPair2 = new ColorPair { MajorColor = System.Drawing.Color.Yellow, MinorColor = System.Drawing.Color.Green };
            pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            System.Diagnostics.Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair { MajorColor = System.Drawing.Color.Red, MinorColor = System.Drawing.Color.Blue };
            pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            System.Diagnostics.Debug.Assert(pairNumber == 6);

            // Print reference manual
            Console.WriteLine("\nReference Manual:");
            ReferenceManualPrinter.PrintReferenceManual(Console.WriteLine);
        }
    }
}
