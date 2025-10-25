using System;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string holderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }
}
