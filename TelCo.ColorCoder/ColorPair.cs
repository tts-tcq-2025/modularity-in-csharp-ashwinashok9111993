using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Represents a color pair with major and minor colors.
    /// </summary>
    public record ColorPair(Color MajorColor, Color MinorColor)
    {
        public override string ToString() => $"MajorColor:{MajorColor.Name}, MinorColor:{MinorColor.Name}";
    }
}
