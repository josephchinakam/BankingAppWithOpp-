using System;

namespace BankingSystem
{
    public class SavingsAccount : BankAccount
    {
        private const decimal MinimumBalance = 50.00m;

        public SavingsAccount(string accountNumber, string holderName, decimal initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < MinimumBalance)
            {
                Console.WriteLine($"Cannot withdraw: The balance cannot go below {MinimumBalance:C}.");
            }
            else
            {
                base.Withdraw(amount);
            }
        }
    }
}
