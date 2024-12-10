namespace lab5;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelStatus = new Label();
        labelBalance = new Label();
        panelOperations = new Panel();
        buttonWithdraw = new Button();
        buttonLoad = new Button();
        textBoxAmount = new TextBox();
        panelAuth = new Panel();
        buttonEnterPin = new Button();
        textBoxPin = new TextBox();
        labelMessage = new Label();
        buttonExit = new Button();
        panelOperations.SuspendLayout();
        panelAuth.SuspendLayout();
        SuspendLayout();
        // 
        // labelStatus
        // 
        labelStatus.ForeColor = SystemColors.Control;
        labelStatus.Location = new Point(15, 9);
        labelStatus.Margin = new Padding(6, 0, 6, 0);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(354, 50);
        labelStatus.TabIndex = 0;
        labelStatus.Text = "labelStatus";
        labelStatus.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelBalance
        // 
        labelBalance.BackColor = SystemColors.ActiveCaptionText;
        labelBalance.FlatStyle = FlatStyle.System;
        labelBalance.ForeColor = SystemColors.Control;
        labelBalance.Location = new Point(15, 22);
        labelBalance.Margin = new Padding(6, 0, 6, 0);
        labelBalance.Name = "labelBalance";
        labelBalance.Size = new Size(357, 50);
        labelBalance.TabIndex = 1;
        labelBalance.Text = "labelBalance";
        labelBalance.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelOperations
        // 
        panelOperations.Controls.Add(buttonExit);
        panelOperations.Controls.Add(buttonWithdraw);
        panelOperations.Controls.Add(buttonLoad);
        panelOperations.Controls.Add(textBoxAmount);
        panelOperations.Controls.Add(labelBalance);
        panelOperations.Location = new Point(0, 153);
        panelOperations.Name = "panelOperations";
        panelOperations.Size = new Size(384, 295);
        panelOperations.TabIndex = 2;
        // 
        // buttonWithdraw
        // 
        buttonWithdraw.Location = new Point(211, 148);
        buttonWithdraw.Name = "buttonWithdraw";
        buttonWithdraw.Size = new Size(158, 56);
        buttonWithdraw.TabIndex = 3;
        buttonWithdraw.Text = "Вывести";
        buttonWithdraw.UseVisualStyleBackColor = true;
        buttonWithdraw.Click += buttonWithdraw_Click;
        // 
        // buttonLoad
        // 
        buttonLoad.Location = new Point(15, 148);
        buttonLoad.Name = "buttonLoad";
        buttonLoad.Size = new Size(158, 56);
        buttonLoad.TabIndex = 3;
        buttonLoad.Text = "Положить";
        buttonLoad.UseVisualStyleBackColor = true;
        buttonLoad.Click += buttonLoad_Click;
        // 
        // textBoxAmount
        // 
        textBoxAmount.Location = new Point(131, 78);
        textBoxAmount.Name = "textBoxAmount";
        textBoxAmount.Size = new Size(119, 31);
        textBoxAmount.TabIndex = 2;
        // 
        // panelAuth
        // 
        panelAuth.Controls.Add(buttonEnterPin);
        panelAuth.Controls.Add(textBoxPin);
        panelAuth.Location = new Point(0, 153);
        panelAuth.Name = "panelAuth";
        panelAuth.Size = new Size(384, 257);
        panelAuth.TabIndex = 2;
        // 
        // buttonEnterPin
        // 
        buttonEnterPin.Location = new Point(150, 137);
        buttonEnterPin.Name = "buttonEnterPin";
        buttonEnterPin.Size = new Size(100, 50);
        buttonEnterPin.TabIndex = 1;
        buttonEnterPin.Text = "Ввести";
        buttonEnterPin.UseVisualStyleBackColor = true;
        buttonEnterPin.Click += buttonEnterPin_Click;
        // 
        // textBoxPin
        // 
        textBoxPin.Location = new Point(150, 41);
        textBoxPin.MaxLength = 4;
        textBoxPin.Name = "textBoxPin";
        textBoxPin.PasswordChar = '*';
        textBoxPin.Size = new Size(100, 31);
        textBoxPin.TabIndex = 0;
        textBoxPin.TextAlign = HorizontalAlignment.Center;
        // 
        // labelMessage
        // 
        labelMessage.Font = new Font("Montserrat ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelMessage.ForeColor = SystemColors.Control;
        labelMessage.Location = new Point(15, 59);
        labelMessage.Name = "labelMessage";
        labelMessage.Size = new Size(357, 91);
        labelMessage.TabIndex = 3;
        labelMessage.Text = "labelMessage";
        labelMessage.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // buttonExit
        // 
        buttonExit.Location = new Point(116, 244);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(151, 33);
        buttonExit.TabIndex = 4;
        buttonExit.Text = "Выйти";
        buttonExit.UseVisualStyleBackColor = true;
        buttonExit.Click += buttonExit_Click;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = SystemColors.ActiveCaptionText;
        BackgroundImageLayout = ImageLayout.None;
        ClientSize = new Size(384, 561);
        Controls.Add(labelMessage);
        Controls.Add(panelOperations);
        Controls.Add(labelStatus);
        Controls.Add(panelAuth);
        Font = new Font("Montserrat ExtraBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(6, 5, 6, 5);
        Name = "Form1";
        Text = "ATM";
        panelOperations.ResumeLayout(false);
        panelOperations.PerformLayout();
        panelAuth.ResumeLayout(false);
        panelAuth.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label labelStatus;
    private Label labelBalance;
    private Panel panelOperations;
    private Panel panelAuth;
    private Button buttonEnterPin;
    private TextBox textBoxPin;
    private Label labelMessage;
    private Button buttonWithdraw;
    private Button buttonLoad;
    private TextBox textBoxAmount;
    private Button buttonExit;
}
