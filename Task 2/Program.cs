using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount();
            account1.SetAccountDetails("12345", "Nahin", 500);

            BankAccount account2 = new BankAccount();
            account2.SetAccountDetails("67890", "Mamun", 300);

            Console.WriteLine($"{account1.AccountName} has balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.AccountName} has balance: {account2.Balance:C}");

            account1.Deposit(200);
            account1.Withdraw(100);
            account1.Transfer(account2, 250);

            Console.WriteLine($"{account1.AccountName}'s final balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.AccountName}'s final balance: {account2.Balance:C}");
        }
    }
}
