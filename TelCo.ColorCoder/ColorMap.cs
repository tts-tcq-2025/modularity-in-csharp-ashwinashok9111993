using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Provides color map arrays for major and minor colors.
    /// </summary>
    public static class ColorMap
    {
        public static readonly Color[] MajorColors =
            { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        public static readonly Color[] MinorColors =
            { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
    }
}
