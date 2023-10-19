using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

public class PasswordValidator
{
    public static bool IsPasswordValid(string password)
    {
        // Правила за валидна парола
        int minLength = 8;
        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;

        // Проверка за дължина
        if (password.Length < minLength)
        {
            return false;
        }

        // Проверка за наличие на главни букви, малки букви и цифри
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUppercase = true;
            }
            else if (char.IsLower(c))
            {
                hasLowercase = true;
            }
            else if (char.IsDigit(c))
            {
                hasDigit = true;
            }
        }

        // Проверка дали паролата изпълнява всички правила
        return hasUppercase && hasLowercase && hasDigit;
    }
}
