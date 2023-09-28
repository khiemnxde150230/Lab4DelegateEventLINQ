using System;

public delegate void BalanceChangedEventHandler(decimal newBalance);

public class Account
{
    private decimal balance;

    public event BalanceChangedEventHandler BalanceChanged;

    public decimal Balance
    {
        get { return balance; }
        private set
        {
            balance = value;
            OnBalanceChanged(balance);
        }
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    protected virtual void OnBalanceChanged(decimal newBalance)
    {
        BalanceChanged?.Invoke(newBalance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();
        account.BalanceChanged += BalanceChangedEventHandlerMethod;

        account.Deposit(1000);
        account.Deposit(1000);
        account.Withdraw(500);

        Console.ReadLine();
    }

    static void BalanceChangedEventHandlerMethod(decimal newBalance)
    {
        Console.WriteLine($"New account balance: {newBalance}");
    }
}
