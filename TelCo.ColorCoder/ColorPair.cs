using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Represents a color pair with major and minor colors.
    /// </summary>
    public class ColorPair
    {
        public Color MajorColor { get; set; }
        public Color MinorColor { get; set; }
        public override string ToString()
        {
            return $"MajorColor:{MajorColor.Name}, MinorColor:{MinorColor.Name}";
        }
    }
}
