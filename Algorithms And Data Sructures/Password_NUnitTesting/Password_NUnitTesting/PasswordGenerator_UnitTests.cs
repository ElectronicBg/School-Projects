using NUnit.Framework;
using System.Linq;
using System;

namespace PasswordGenerator_NUnitTesting
{
    public class Tests
    {
        [Test]
        public void TestGenerateRandomPassword_ValidLength()
        {
            // Arrange
            int length = 12;

            // Act
            string password = PasswordGenerator.GenerateRandomPassword(length);

            // Assert
            Assert.AreEqual(length, password.Length);
        }

        [Test]
        public void TestGenerateRandomPassword_ContainsUppercase()
        {
            // Arrange
            int length = 12;

            // Act
            string password = PasswordGenerator.GenerateRandomPassword(length);

            // Assert
            Assert.IsTrue(password.Any(char.IsUpper), "Password should contain at least one uppercase character.");
        }

        [Test]
        public void TestGenerateRandomPassword_ContainsLowercase()
        {
            // Arrange
            int length = 12;

            // Act
            string password = PasswordGenerator.GenerateRandomPassword(length);

            // Assert
            Assert.IsTrue(password.Any(char.IsLower), "Password should contain at least one lowercase character.");
        }

        [Test]
        public void TestGenerateRandomPassword_ContainsDigit()
        {
            // Arrange
            int length = 12;

            // Act
            string password = PasswordGenerator.GenerateRandomPassword(length);

            // Assert
            Assert.IsTrue(password.Any(char.IsDigit), "Password should contain at least one digit.");
        }

        [Test]
        public void TestGenerateRandomPassword_InvalidLength()
        {
            // Arrange
            int invalidLength = 0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => PasswordGenerator.GenerateRandomPassword(invalidLength));
        }
    }
}