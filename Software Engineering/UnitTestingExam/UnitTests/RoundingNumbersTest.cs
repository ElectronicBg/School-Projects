using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using RoundingNumbers;

namespace RoundingNumbers.Tests
{
    public class RoundingNumbersTest
    {
        [Test]
        public void RoundNumbers_RoundInputNumbers_Success()
        {
            // Arrange
            double[] inputNumbers = { 1.3, 2.7, 3.5 };
            double[] expectedOutput = { 1, 3, 4 };

            // Act
            double[] actualOutput = Program.RoundNumbers(inputNumbers);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void RoundNumbers_EmptyArray_InputAndOutputAreEmpty()
        {
            // Arrange
            double[] inputNumbers = Array.Empty<double>();
            double[] expectedOutput = Array.Empty<double>();

            // Act
            double[] actualOutput = Program.RoundNumbers(inputNumbers);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
