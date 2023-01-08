namespace Facade;

public class CashMachineFacade
{
    protected CashMachine _cashMachine;

    public CashMachineFacade(CashMachine cashMachine)
    {
        _cashMachine = cashMachine;
    }

    public void GetBalance()
    {
        Console.WriteLine($"Your balance is: {_cashMachine.GetBalance()}");
    }

    public void AddMoney(int money)
    {
        _cashMachine.AddMoney(money);
    }

    public void WithdrawMoney(int money)
    {
        _cashMachine.WithdrawMoney(money);
    }
}