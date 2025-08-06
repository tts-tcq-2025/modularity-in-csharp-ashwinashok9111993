using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Provides mapping between pair numbers and color pairs.
    /// </summary>
    public class ColorCoder
    {
        private static readonly List<ColorPair> AllPairs = (
            from major in ColorMap.MajorColors
            from minor in ColorMap.MinorColors
            select new ColorPair { MajorColor = major, MinorColor = minor }
        ).ToList();
        private static readonly Dictionary<(Color, Color), int> PairToNumber =
            AllPairs.Select((pair, idx) => (pair, idx)).ToDictionary(x => (x.pair.MajorColor, x.pair.MinorColor), x => x.idx + 1);

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > AllPairs.Count)
                throw new ArgumentOutOfRangeException($"Argument PairNumber:{pairNumber} is outside the allowed range");
            return AllPairs[pairNumber - 1];
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            if (!PairToNumber.TryGetValue((pair.MajorColor, pair.MinorColor), out int pairNumber))
                throw new ArgumentException($"Unknown Colors: {pair}");
            return pairNumber;
        }
    }
}
