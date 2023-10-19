using System.Text;
using System;

public class PasswordGenerator
{
    private static Random random = new Random();
    private const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
    private const string digitChars = "0123456789";

    public static string GenerateRandomPassword(int length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Дължината на паролата трябва да бъде по-голяма от 0.");
        }

        var password = new StringBuilder();
        var allChars = uppercaseChars + lowercaseChars + digitChars;

        // Генериране на поне по един символ от всяка група
        password.Append(GetRandomChar(uppercaseChars));
        password.Append(GetRandomChar(lowercaseChars));
        password.Append(GetRandomChar(digitChars));

        // Генериране на останалите символи
        for (int i = 3; i < length; i++)
        {
            password.Append(GetRandomChar(allChars));
        }

        // Разбъркване на символите в паролата
        for (int i = 0; i < password.Length; i++)
        {
            int swapIndex = random.Next(i, password.Length);
            char temp = password[i];
            password[i] = password[swapIndex];
            password[swapIndex] = temp;
        }

        return password.ToString();
    }

    private static char GetRandomChar(string charSet)
    {
        int index = random.Next(0, charSet.Length);
        return charSet[index];
    }
}