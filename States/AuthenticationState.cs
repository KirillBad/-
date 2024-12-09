using System;
using System.Windows.Forms;

public class AuthenticationState : IState
{
    private int attempts = 3;

    public void EnterPin(ATM atm, string pin)
    {
        if (pin == "1234") // Для примера используем фиксированный PIN
        {
            atm.SetState(new OperationalState());
        }
        else
        {
            attempts--;
            if (attempts <= 0)
            {
                atm.SetState(new BlockedState());
            }
            MessageBox.Show($"Неверный PIN. Осталось попыток: {attempts}");
        }
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        MessageBox.Show("Сначала завершите аутентификацию");
    }

    public void FinishWork(ATM atm)
    {
        atm.SetState(new WaitingState());
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        MessageBox.Show("Невозможно загрузить деньги в текущем состоянии");
    }
} 