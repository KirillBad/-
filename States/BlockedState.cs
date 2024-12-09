using System;
using System.Windows.Forms;

public class BlockedState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        MessageBox.Show("Банкомат заблокирован");
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        MessageBox.Show("Банкомат заблокирован");
    }

    public void FinishWork(ATM atm)
    {
        MessageBox.Show("Банкомат заблокирован");
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        atm.AddMoney(amount);
        if (atm.TotalMoney > 0)
        {
            atm.SetState(new WaitingState());
            MessageBox.Show($"Загружено {amount:C}. Банкомат разблокирован");
        }
    }
} 