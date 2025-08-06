using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Responsible for mapping between pair numbers and color pairs.
    /// </summary>
    public static class ColorPairMapper
    {
        private static readonly IReadOnlyList<ColorPair> AllPairs = 
            ColorMap.MajorColors.SelectMany(major => 
                ColorMap.MinorColors.Select(minor => 
                    new ColorPair(major, minor)))
            .ToList();

        private static readonly IReadOnlyDictionary<(Color Major, Color Minor), int> PairToNumber =
            AllPairs.Select((pair, idx) => new { pair, idx })
                   .ToDictionary(x => (x.pair.MajorColor, x.pair.MinorColor), x => x.idx + 1);

        public static ColorPair GetColorFromPairNumber(int pairNumber) =>
            pairNumber is >= 1 and <= 25 
                ? AllPairs[pairNumber - 1]
                : throw new ArgumentOutOfRangeException(nameof(pairNumber), $"Pair number {pairNumber} is outside range 1-25");

        public static int GetPairNumberFromColor(ColorPair pair) =>
            PairToNumber.TryGetValue((pair.MajorColor, pair.MinorColor), out int pairNumber)
                ? pairNumber
                : throw new ArgumentException($"Unknown color combination: {pair}", nameof(pair));

        public static IReadOnlyList<ColorPair> GetAllPairs() => AllPairs;
    }
}
