public class ATM
{
    private IState _currentState;
    public string ID { get; private set; }
    public decimal TotalMoney { get; private set; }
    public double ConnectionFailureProbability { get; private set; }
    
    public ATM(string id, decimal initialMoney, double failureProbability)
    {
        ID = id;
        TotalMoney = initialMoney;
        ConnectionFailureProbability = failureProbability;
        _currentState = new WaitingState();
    }

    public void SetState(IState state)
    {
        _currentState = state;
    }

    public void EnterPin(string pin)
    {
        _currentState.EnterPin(this, pin);
    }

    public void WithdrawMoney(decimal amount)
    {
        _currentState.WithdrawMoney(this, amount);
    }

    public void FinishWork()
    {
        _currentState.FinishWork(this);
    }

    public void LoadMoney(decimal amount)
    {
        _currentState.LoadMoney(this, amount);
    }

    public void AddMoney(decimal amount)
    {
        TotalMoney += amount;
    }

    public bool TryWithdraw(decimal amount)
    {
        if (TotalMoney >= amount)
        {
            TotalMoney -= amount;
            return true;
        }
        return false;
    }
} 