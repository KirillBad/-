using System;
using System.Windows.Forms;
using System.Drawing;

public partial class Form1 : Form, IObserver
{
    private readonly OrganizationController _controller;
    private readonly OrganizationModel _model;
    private decimal _lastPremium = 0;

    public Form1()
    {
        InitializeComponent();
        
        _model = new OrganizationModel("", "", 1);
        _model.AddObserver(this);
        _controller = new OrganizationController(_model);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Введите название компании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtAddress.Text))
        {
            MessageBox.Show("Введите адрес компании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _controller.SetName(txtName.Text);
        _controller.SetAddress(txtAddress.Text);
        _controller.SetEmployeeCount((int)numEmployees.Value);
        
        MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        UpdateRevenueLabel();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_model.Name))
        {
            MessageBox.Show("Сначала сохраните данные компании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _lastPremium = _controller.CalculateInsurancePremium();
        MessageBox.Show($"Рассчитанная страховая премия #{_model.PremiumCount}: {_lastPremium:C}", 
            "Расчет премии", MessageBoxButtons.OK, MessageBoxIcon.Information);
        UpdateRevenueLabel();
    }

    private void btnProcess_Click(object sender, EventArgs e)
    {
        if (_lastPremium == 0)
        {
            MessageBox.Show("Сначала рассчитайте страховую премию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _controller.ProcessClaim(_lastPremium * 0.1m);
        MessageBox.Show($"Обработана страховая претензия на сумму {_lastPremium * 0.1m:C}", 
            "Обработка претензии", MessageBoxButtons.OK, MessageBoxIcon.Information);
        UpdateRevenueLabel();
    }

    public new void Update()
    {
        if (InvokeRequired)
        {
            Invoke(new Action(UpdateRevenueLabel));
        }
        else
        {
            UpdateRevenueLabel();
        }
    }

    private void UpdateRevenueLabel()
    {
        lblRevenue.Text = $"Текущая выручка: {_model.Revenue:C} (Количество премий: {_model.PremiumCount})";
    }
}