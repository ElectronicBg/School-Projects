using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using ReversingString;

namespace ReversingString.Tests
{
    public class ProgramTests
    {
        [Test]
        public void ReverseStringArray_InputArrayIsReversed_Success()
        {
            // Arrange
            string[] inputs = { "apple", "banana", "cherry" };
            string[] expectedOutput = { "cherry", "banana", "apple" };

            // Act
            string[] actualOutput = Program.ReverseStringArray(inputs);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void ReverseStringArray_EmptyArray_InputAndOutputAreEmpty()
        {
            // Arrange
            string[] inputs = Array.Empty<string>();
            string[] expectedOutput = Array.Empty<string>();

            // Act
            string[] actualOutput = Program.ReverseStringArray(inputs);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
