using NUnit.Framework;

namespace PasswordValidator_NUnitTesting
{
    public class Tests
    {
        [Test]
        public void TestValidPassword()
        {
            // Arrange
            string validPassword = "ValidPass123";

            // Act
            bool result = PasswordValidator.IsPasswordValid(validPassword);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TestPasswordTooShort()
        {
            // Arrange
            string shortPassword = "Short";

            // Act
            bool result = PasswordValidator.IsPasswordValid(shortPassword);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestPasswordMissingUppercase()
        {
            // Arrange
            string password = "noupper123";

            // Act
            bool result = PasswordValidator.IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestPasswordMissingLowercase()
        {
            // Arrange
            string password = "NOLOWER123";

            // Act
            bool result = PasswordValidator.IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestPasswordMissingDigit()
        {
            // Arrange
            string password = "NoDigitHere";

            // Act
            bool result = PasswordValidator.IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result);
        }
    }
}