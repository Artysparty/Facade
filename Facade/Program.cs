using Facade;

CashMachine cashMachine = new CashMachine(1000);
CashMachineFacade facade = new CashMachineFacade(cashMachine);

facade.AddMoney(100);
facade.GetBalance();
facade.WithdrawMoney(600);