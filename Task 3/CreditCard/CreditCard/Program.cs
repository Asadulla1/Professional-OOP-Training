using System;

class Program
{
    static void Main(string[] args)
    {
        CreditCard myCard = new CreditCard();

        double result1 = myCard.WithdrawCash(15000);
        PrintResult(result1, "Withdraw Cash (15000)");

        double result2 = myCard.PayBill(30000);
        PrintResult(result2, "Pay Bill (30000)");

        double result3 = myCard.WithdrawCash(25000);
        PrintResult(result3, "Withdraw Cash (25000)");

        double resetResult = myCard.ResetDailyLimit();
        PrintResult(resetResult, "Reset Daily Limit");

        double result4 = myCard.WithdrawCash(50000);
        PrintResult(result4, "Withdraw Cash (50000)");

        double finalBalance = myCard.GetBalance();
        Console.WriteLine($"Final balance: {finalBalance}");
    }

    static void PrintResult(double result, string action)
    {
        if (result == -1)
        {
            Console.WriteLine($"{action}: Failed (Transaction exceeds per-transaction limit)");
        }
        else if (result == -2)
        {
            Console.WriteLine($"{action}: Failed (Daily withdrawal limit exceeded)");
        }
        else if (result == -3)
        {
            Console.WriteLine($"{action}: Failed (Insufficient funds)");
        }
        else if (result == 0)
        {
            Console.WriteLine($"{action}: Successfully reset the daily withdrawal limit");
        }
        else
        {
            Console.WriteLine($"{action}: Success. Remaining balance: {result}");
        }
    }
}
