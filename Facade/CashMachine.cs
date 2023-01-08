namespace Facade;

public class CashMachine
{
    public int balance { get; set; }

    public CashMachine(int balance)
    {
        this.balance = balance;
    }

    public int GetBalance()
    {
        return balance;
    }

    public void AddMoney(int money)
    {
        this.balance = balance + money;
        Console.WriteLine($"Money added, your balance: {balance}");
    }

    public void WithdrawMoney(int money)
    {
        this.balance = balance - money;
        Console.WriteLine($"Money withdrawed, your balance: {balance}");
    }
    
}