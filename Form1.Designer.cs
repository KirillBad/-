using System;
using System.Windows.Forms;
using System.Drawing;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        
        txtName = new TextBox();
        txtAddress = new TextBox();
        numEmployees = new NumericUpDown();
        lblRevenue = new Label();
        btnSave = new Button();
        btnCalculate = new Button();
        btnProcess = new Button();
        
        ((System.ComponentModel.ISupportInitialize)(numEmployees)).BeginInit();
        
        Text = "Управление страховой компанией";
        Size = new Size(470, 210);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        
        var lblName = new Label { Text = "Название компании:", Location = new Point(10, 15), AutoSize = true };
        txtName.Location = new Point(150, 12);
        txtName.Size = new Size(300, 20);
        
        var lblAddress = new Label { Text = "Адрес:", Location = new Point(10, 45), AutoSize = true };
        txtAddress.Location = new Point(150, 42);
        txtAddress.Size = new Size(300, 20);
        
        var lblEmployees = new Label { Text = "Кол-во клиентов:", Location = new Point(10, 75), AutoSize = true };
        numEmployees.Location = new Point(150, 72);
        numEmployees.Size = new Size(120, 20);
        numEmployees.Maximum = 1000;
        numEmployees.Minimum = 1;
        numEmployees.Value = 1;
        
        lblRevenue.Location = new Point(10, 105);
        lblRevenue.Size = new Size(440, 20);
        lblRevenue.Text = "Текущая выручка: 0 руб.";
        
        var buttonHeight = 30;
        var buttonY = 135;

        btnSave.Text = "Сохранить данные";
        btnSave.Location = new Point(10, buttonY);
        btnSave.Size = new Size(140, buttonHeight);
        btnSave.Click += btnSave_Click;
        btnSave.FlatStyle = FlatStyle.System;
        btnSave.UseVisualStyleBackColor = true;
        btnSave.TextAlign = ContentAlignment.MiddleCenter;

        btnCalculate.Text = "Рассчитать премию";
        btnCalculate.Location = new Point(160, buttonY);
        btnCalculate.Size = new Size(140, buttonHeight);
        btnCalculate.Click += btnCalculate_Click;
        btnCalculate.FlatStyle = FlatStyle.System;
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.TextAlign = ContentAlignment.MiddleCenter;
        
        btnProcess.Text = "Обработать претензию";
        btnProcess.Location = new Point(310, buttonY);
        btnProcess.Size = new Size(140, buttonHeight);
        btnProcess.Click += btnProcess_Click;
        btnProcess.FlatStyle = FlatStyle.System;
        btnProcess.UseVisualStyleBackColor = true;
        btnProcess.TextAlign = ContentAlignment.MiddleCenter;
        
        Controls.AddRange(new Control[] {
            lblName, txtName,
            lblAddress, txtAddress,
            lblEmployees, numEmployees,
            lblRevenue,
            btnSave, btnCalculate, btnProcess
        });

        ((System.ComponentModel.ISupportInitialize)(numEmployees)).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private TextBox txtName;
    private TextBox txtAddress;
    private NumericUpDown numEmployees;
    private Label lblRevenue;
    private Button btnSave;
    private Button btnCalculate;
    private Button btnProcess;
}
