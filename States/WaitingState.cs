public class WaitingState : IState
{
    public void EnterPin(ATM atm, string pin)
    {
        atm.SetMessage("Связь восстановлена");
        atm.SetState(atm._previousState);
    }

    public void WithdrawMoney(ATM atm, decimal amount)
    {
        atm.SetMessage("Связь восстановлена");
        atm.SetState(atm._previousState);

    }

    public void FinishWork(ATM atm)
    {
        atm.SetMessage("Связь восстановлена");
        atm.SetState(new AuthenticationState());
    }

    public void LoadMoney(ATM atm, decimal amount)
    {
        atm.SetMessage("Связь восстановлена");
        atm.SetState(atm._previousState);
    }
} 