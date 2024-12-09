namespace lab5;

public partial class Form1 : Form
{
    private ATM _atm;

    public Form1()
    {
        InitializeComponent();
        _atm = new ATM("ATM001", 10000, 0.1);
        UpdateStatus();
    }

    private void UpdateStatus()
    {
        // labelBalance.Text = $"Баланс: {_atm.TotalMoney:C}";
        // Обновление других элементов интерфейса
    }
}
