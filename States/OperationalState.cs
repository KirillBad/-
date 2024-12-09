using System;
using System.Windows.Forms;

public class OperationalState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        MessageBox.Show("PIN уже введен");
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        if (atm.TryWithdraw(amount))
        {
            MessageBox.Show($"Выдано {amount:C}");
            if (atm.TotalMoney == 0)
            {
                atm.SetState(new BlockedState());
            }
        }
        else
        {
            MessageBox.Show("Недостаточно средств");
        }
    }

    public void FinishWork(ATM atm)
    {
        atm.SetState(new WaitingState());
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        MessageBox.Show("Завершите текущую сессию");
    }
} 