public class OperationalState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        atm.SetMessage("PIN уже введен");
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        if (atm.TryWithdraw(amount))
        {
            atm.SetMessage($"Выдано {amount}$");
            if (atm.TotalMoney == 0)
            {
                atm.SetState(new BlockedState());
                atm.SetMessage("В банкомате нет денег");
            }
        }
        else
        {
            atm.SetMessage("Недостаточно средств");
        }
    }

    public void FinishWork(ATM atm)
    {
        atm.SetState(new AuthenticationState());
        atm.SetMessage("До свидания!");
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        atm.AddMoney(amount);
        atm.SetMessage($"Загружено {amount}$");
    }
} 