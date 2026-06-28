using System;

public class Account(string name = "Unnamed Account", double balance = 0.0)
{
    public string name { get; set; } = name;
    public double balance { get; set; } = balance;

    public virtual bool Deposit(double amount)
    {
        if (amount < 0)
            return false;
        else
        {
            balance += amount;
            return true;
        }
    }

    public virtual bool Withdraw(double amount)
    {
        if (balance - amount >= 0)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public double GetBalance()
    {
        return balance;
    }

    public override string ToString()
    {
        return $"[Account: {name}: {balance}]";
    }
}
