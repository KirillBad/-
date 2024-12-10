namespace lab5;

public partial class Form1 : Form
{
    private ATM _atm;

    public Form1()
    {
        InitializeComponent();
        _atm = new ATM("ATM001", 10000, 0.1);
        _atm.StateChanged += Atm_StateChanged;
        UpdateStatus();
    }

    private void Atm_StateChanged(object? sender, EventArgs e)
    {
        UpdateStatus();
    }

    private void UpdateStatus()
    {

        labelMessage.Text = _atm.StatusMessage;

        if (_atm._currentState is WaitingState)
            labelStatus.Text = "Статус: Ожидание";
        else if (_atm._currentState is AuthenticationState)
        {
            labelStatus.Text = "Статус: Аунтефикация";
            panelAuth.Visible = true;
            panelOperations.Visible = false;
        }
        else if (_atm._currentState is OperationalState)
        {
            labelStatus.Text = "Статус: Работа";
            panelAuth.Visible = false;
            panelOperations.Visible = true;
            labelBalance.Text = $"Баланс: {_atm.TotalMoney}$";
        }
        else if (_atm._currentState is BlockedState)
        {
            labelStatus.Text = "Статус: Заблокирован";
            panelAuth.Visible = false;
            panelOperations.Visible = true;
        }
    }

    private void buttonEnterPin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxPin.Text))
        {
            labelStatus.Text = "Введите PIN-код";
            return;
        }

        _atm.EnterPin(textBoxPin.Text);
        textBoxPin.Clear();
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
        if (decimal.TryParse(textBoxAmount.Text, out decimal amount) && amount > 0)
        {
            _atm.LoadMoney(amount);
            textBoxAmount.Clear();
            labelBalance.Text = $"Баланс: {_atm.TotalMoney}$";
        }
        else
        {
            labelMessage.Text = "Введите корректную сумму для внесения";
        }
    }

    private void buttonWithdraw_Click(object sender, EventArgs e)
    {
        if (decimal.TryParse(textBoxAmount.Text, out decimal amount) && amount > 0)
        {
            _atm.WithdrawMoney(amount);
            textBoxAmount.Clear();
            labelBalance.Text = $"Баланс: {_atm.TotalMoney}$";
        }
        else
        {
            labelMessage.Text = "Введите корректную сумму для снятия";
        }
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        _atm.FinishWork();
    }
}

