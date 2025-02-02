using System;

public class CreditCard
{
    private const double MaxLimit = 500000;
    private double balance;
    private double dailyWithdrawalLimit = 100000;
    private double perTransactionLimit = 20000;
    private double totalWithdrawnToday;

    public CreditCard()
    {
        balance = MaxLimit;
        totalWithdrawnToday = 0;
    }

    public double WithdrawCash(double amount)
    {
        if (amount > perTransactionLimit)
        {
            return -1;
        }

        if (totalWithdrawnToday + amount > dailyWithdrawalLimit)
        {
            return -2;
        }

        if (balance - amount < 0)
        {
            return -3;
        }

        balance -= amount;
        totalWithdrawnToday += amount;
        return balance;
    }

    public double PayBill(double amount)
    {
        if (balance - amount < 0)
        {
            return -3;
        }

        balance -= amount;
        return balance;
    }

    public double ResetDailyLimit()
    {
        totalWithdrawnToday = 0;
        return 0;
    }

    public double GetBalance()
    {
        return balance;
    }
}
