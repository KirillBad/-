using System;
using System.Windows.Forms;

public class WaitingState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        atm.SetState(new AuthenticationState());
        // Можно добавить событие для обновления UI
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        MessageBox.Show("Сначала введите PIN-код");
    }

    public void FinishWork(ATM atm)
    {
        // Уже в состоянии ожидания
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        atm.AddMoney(amount);
        MessageBox.Show($"Загружено {amount:C}");
    }
} 