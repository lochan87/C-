using System;

class BankAccount
{
    private string accountHolder, accountNumber;
    private double balance;

    public BankAccount(string name, double initialBalance)
    {
        accountHolder = name;
        balance = initialBalance;
        accountNumber = GenerateAccountNumber();
    }

    private string GenerateAccountNumber()
    {
        Random random = new Random();
        return "AB" + random.Next(1000000, 9999999).ToString();
    }
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited ₹{amount}.\nNew Balance: ₹{balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew ₹{amount}.\nNew Balance: ₹{balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: ₹{balance}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("\n--- Simple Banking System ---");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        BankAccount account = new BankAccount(name, 0);

        int choice;
        do
        {
            Console.WriteLine("\n--- Anand Bank ---");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    account.Deposit(deposit);
                    break;

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;

                case 3:
                    account.ShowBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using Anand bank!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 4);
    }
}
