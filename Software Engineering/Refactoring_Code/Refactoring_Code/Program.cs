using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; }
    public string AccountHolder { get; }
    public double Balance { get; private set; }

    // Constructor
    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    // Deposit method
    public bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true; // Deposit successful
        }
        return false; // Deposit failed
    }

    // Withdraw method
    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return true; // Withdrawal successful
        }
        return false; // Withdrawal failed
    }

    // Get account information
    public string GetAccountInfo()
    {
        return $"Account Number: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance}";
    }
}

class Program
{
    // Perform a transaction (deposit or withdraw) and display the result
    static void PerformTransaction(BankAccount account, string transactionType, double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please provide a positive amount.");
            return;
        }

        bool success = false;

        if (transactionType == "Deposit")
        {
            success = account.Deposit(amount);
        }
        else if (transactionType == "Withdraw")
        {
            success = account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Invalid transaction type");
            return;
        }

        if (success)
        {
            Console.WriteLine($"{transactionType} successful");
        }
        else
        {
            Console.WriteLine($"{transactionType} failed");
        }
    }


    // Display account information
    static void DisplayAccountInfo(BankAccount account)
    {
        Console.WriteLine(account.GetAccountInfo());
    }

    static void Main()
    {
        // Create a bank account
        BankAccount account1 = new BankAccount("12345", "Иван Петров", 1000);

        // Deposit, withdraw, and display account info
        PerformTransaction(account1, "Deposit", 500);
        PerformTransaction(account1, "Withdraw", 200);
        DisplayAccountInfo(account1);
    }
}
