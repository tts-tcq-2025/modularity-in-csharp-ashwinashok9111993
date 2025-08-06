using System;
using System.Drawing;
using TelCo.ColorCoder;
using Xunit;

namespace TelCo.ColorCoder.Tests
{
    public class ColorPairMapperTests
    {
        [Theory]
        [InlineData(4, "White", "Brown")]
        [InlineData(5, "White", "SlateGray")]
        [InlineData(23, "Violet", "Green")]
        public void GetColorFromPairNumber_ReturnsCorrectColors(int pairNumber, string expectedMajor, string expectedMinor)
        {
            var pair = ColorPairMapper.GetColorFromPairNumber(pairNumber);
            Assert.Equal(expectedMajor, pair.MajorColor.Name);
            Assert.Equal(expectedMinor, pair.MinorColor.Name);
        }

        [Theory]
        [InlineData("Yellow", "Green", 18)]
        [InlineData("Red", "Blue", 6)]
        public void GetPairNumberFromColor_ReturnsCorrectPairNumber(string major, string minor, int expectedPairNumber)
        {
            var pair = new ColorPair(Color.FromName(major), Color.FromName(minor));
            int pairNumber = ColorPairMapper.GetPairNumberFromColor(pair);
            Assert.Equal(expectedPairNumber, pairNumber);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(26)]
        [InlineData(-1)]
        public void GetColorFromPairNumber_ThrowsForInvalidPairNumber(int invalidPairNumber) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => ColorPairMapper.GetColorFromPairNumber(invalidPairNumber));

        [Fact]
        public void GetPairNumberFromColor_ThrowsForInvalidColor() =>
            Assert.Throws<ArgumentException>(() => ColorPairMapper.GetPairNumberFromColor(new ColorPair(Color.Pink, Color.Orange)));

        [Fact]
        public void GetAllPairs_Returns25Pairs() => Assert.Equal(25, ColorPairMapper.GetAllPairs().Count);
    }
}
