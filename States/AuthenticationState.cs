public class AuthenticationState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        if (pin == "1234")
        {
            atm.SetState(new OperationalState());
            atm.SetMessage("Здравствуйте!");
        }
        else
        {
            atm.SetMessage("Неверный PIN.");
        }
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        atm.SetMessage("Сначала завершите аутентификацию");
    }

    public void FinishWork(ATM atm)
    {
        atm.SetMessage("Сначала завершите аутентификацию");
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        atm.SetMessage("Невозможно загрузить деньги в текущем состоянии");
    }
} 