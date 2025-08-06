using System;
using System.Collections.Generic;
using TelCo.ColorCoder;
using Xunit;

namespace TelCo.ColorCoder.Tests
{
    public class ReferenceManualPrinterTests
    {
        [Fact]
        public void PrintReferenceManual_LogsAll25Pairs()
        {
            var output = new List<string>();
            ReferenceManualPrinter.PrintReferenceManual(output.Add);
            Assert.Equal(25, output.Count);
            Assert.Contains(output, line => line.Contains("1:"));
            Assert.Contains(output, line => line.Contains("25:"));
            Assert.Contains(output, line => line.Contains("White"));
            Assert.Contains(output, line => line.Contains("SlateGray"));
        }
    }
}
