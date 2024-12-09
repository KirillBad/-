public interface IState
{
    void EnterPin(ATM atm, string pin);
    void WithdrawMoney(ATM atm, decimal amount);
    void FinishWork(ATM atm);
    void LoadMoney(ATM atm, decimal amount);
} 