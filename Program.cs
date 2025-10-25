using System;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Savings Account
            BankAccount savings = new SavingsAccount("SA12345", "John Doe", 1000.00m);
            Console.WriteLine($"Savings Account: {savings.HolderName}, Balance: {savings.Balance:C}");

            // Deposit into Savings Account
            savings.Deposit(500.00m);

            // Withdraw from Savings Account
            savings.Withdraw(300.00m);
            savings.Withdraw(1200.00m);  // This should fail because it would go below $50

            Console.WriteLine(); // Add space between account outputs

            // Create a Checking Account
            BankAccount checking = new CheckingAccount("CA12345", "Jane Smith", 1000.00m);
            Console.WriteLine($"Checking Account: {checking.HolderName}, Balance: {checking.Balance:C}");

            // Deposit into Checking Account
            checking.Deposit(500.00m);

            // Withdraw from Checking Account
            checking.Withdraw(1200.00m);  // This should succeed as it's within the overdraft limit
            checking.Withdraw(1500.00m);  // This should fail as it exceeds the overdraft limit
        }
    }
}
