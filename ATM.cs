public class ATM
{
    public event EventHandler? StateChanged;

    public IState _currentState;
    public IState _previousState;
    public string ID { get; private set; }
    public decimal TotalMoney { get; private set; }
    public double ConnectionFailureProbability { get; private set; }
    public string StatusMessage { get; private set; } = "";
    
    public ATM(string id, decimal initialMoney, double failureProbability)
    {
        ID = id;
        TotalMoney = initialMoney;
        ConnectionFailureProbability = failureProbability;
        _currentState = new AuthenticationState();
        _previousState = _currentState;
    }

    public void SetState(IState state)
    {
        _currentState = state;
        StateChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetMessage(string message)
    {
        StatusMessage = message;
        StateChanged?.Invoke(this, EventArgs.Empty);
    }

    public void EnterPin(string pin)
    {
        if (!CheckConnection()) return;
        _currentState.EnterPin(this, pin);
    }

    public void WithdrawMoney(decimal amount)
    {
        if (!CheckConnection()) return;
        _currentState.WithdrawMoney(this, amount);
    }

    public void FinishWork()
    {
        if (!CheckConnection()) return;
        _currentState.FinishWork(this);
    }

    public void LoadMoney(decimal amount)
    {
        if (!CheckConnection()) return;
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

    private bool CheckConnection()
    {
        if (Random.Shared.NextDouble() <= ConnectionFailureProbability)
        {
            if (!(_currentState is WaitingState))
            {
                _previousState = _currentState;
            }
            SetState(new WaitingState());
            SetMessage("Ошибка связи с банком. Пожалуйста, подождите...");
            return false;
        }
        return true;
    }
} 