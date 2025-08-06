using System;
using System.Drawing;
using TelCo.ColorCoder;
using Xunit;

namespace TelCo.ColorCoder.Tests
{
    public class ColorCoderTests
    {
        [Theory]
        [InlineData(4, "White", "Brown")]
        [InlineData(5, "White", "SlateGray")]
        [InlineData(23, "Violet", "Green")]
        public void GetColorFromPairNumber_ReturnsCorrectColors(int pairNumber, string expectedMajor, string expectedMinor)
        {
            var pair = ColorCoder.GetColorFromPairNumber(pairNumber);
            Assert.Equal(expectedMajor, pair.MajorColor.Name);
            Assert.Equal(expectedMinor, pair.MinorColor.Name);
        }

        [Theory]
        [InlineData("Yellow", "Green", 18)]
        [InlineData("Red", "Blue", 6)]
        public void GetPairNumberFromColor_ReturnsCorrectPairNumber(string major, string minor, int expectedPairNumber)
        {
            var pair = new ColorPair { MajorColor = Color.FromName(major), MinorColor = Color.FromName(minor) };
            int pairNumber = ColorCoder.GetPairNumberFromColor(pair);
            Assert.Equal(expectedPairNumber, pairNumber);
        }
    }
}
