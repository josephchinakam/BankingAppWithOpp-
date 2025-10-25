using System;

namespace BankingSystem
{
    public class CheckingAccount : BankAccount
    {
        private const decimal OverdraftLimit = 200.00m;

        public CheckingAccount(string accountNumber, string holderName, decimal initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < -OverdraftLimit)
            {
                Console.WriteLine($"Cannot withdraw: The overdraft limit of {OverdraftLimit:C} has been reached.");
            }
            else
            {
                base.Withdraw(amount);
            }
        }
    }
}
