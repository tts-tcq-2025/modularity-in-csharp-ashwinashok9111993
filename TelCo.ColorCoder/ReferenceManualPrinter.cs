using System;
using System.Linq;

namespace TelCo.ColorCoder
{
    public static class ReferenceManualPrinter
    {
        public static void PrintReferenceManual(Action<string> logger) =>
            ColorPairMapper.GetAllPairs()
                .Select((pair, index) => $"{index + 1,2}: {pair.MajorColor.Name,-10} | {pair.MinorColor.Name}")
                .ToList()
                .ForEach(logger);
    }
}
