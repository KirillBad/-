using System;
using System.Windows.Forms;

public class BlockedState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        atm.SetMessage("В банкомате нет денег");
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        atm.SetMessage("В банкомате нет денег");
    }

    public void FinishWork(ATM atm)
    {
        atm.SetMessage("В банкомате нет денег");
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        atm.AddMoney(amount);
        atm.SetState(new OperationalState());
        atm.SetMessage($"Загружено {amount:C}. Банкомат разблокирован");
    }
} 