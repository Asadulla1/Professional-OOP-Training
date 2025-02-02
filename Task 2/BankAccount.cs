using System;


namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountNumber;
        public string AccountName;
        public decimal Balance;

        public void SetAccountDetails(string accountNumber, string accountName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            Balance = initialBalance >= 0 ? initialBalance : 0; // Ensure no negative balance
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} into {AccountName}'s account. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C} from {AccountName}'s account. New balance: {Balance:C}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
                return false;
            }
        }

        public bool Transfer(BankAccount recipient, decimal amount)
        {
            if (Withdraw(amount))
            {
                recipient.Deposit(amount);
                Console.WriteLine($"Transferred {amount:C} from {AccountName} to {recipient.AccountName}");
                return true;
            }
            else
            {
                Console.WriteLine("Transfer failed due to insufficient balance.");
                return false;
            }
        }
    }
}
