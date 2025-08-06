using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ReferenceManualPrinter
    {
        public static void PrintReferenceManual(Action<string> logger)
        {
            int pairNumber = 1;
            foreach (var major in ColorMap.MajorColors)
            {
                foreach (var minor in ColorMap.MinorColors)
                {
                    logger($"{pairNumber,2}: {major.Name,-10} | {minor.Name,-10}");
                    pairNumber++;
                }
            }
        }
    }
}
