using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

[TestFixture]
public class LeapYearTests
{
    [Test]
    public void IsLeap_YearDivisibleBy4AndNotBy100_Returns1()
    {
        // Arrange
        int year = 2020;

        // Act
        int result = LepYear.IsLeap(year);

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void IsLeap_YearDivisibleBy4AndBy100ButBy400_Returns1()
    {
        // Arrange
        int year = 2000;

        // Act
        int result = LepYear.IsLeap(year);

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void IsLeap_YearNotDivisibleBy4_Returns0()
    {
        // Arrange
        int year = 2023;

        // Act
        int result = LepYear.IsLeap(year);

        // Assert
        Assert.AreEqual(0, result);
    }
}
