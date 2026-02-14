namespace ATM.Simulator
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            Balance = new Button();
            Deposit = new Button();
            Withdraw = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            WithdrawAmount = new TextBox();
            DepositAmount = new TextBox();
            Amount = new Label();
            label1 = new Label();
            BalanceCheck = new Label();
            BalanceAmount = new Label();
            SuspendLayout();

            Balance.BackColor = Color.Lime;
            Balance.Location = new Point(12, 12);
            Balance.Name = "Balance";
            Balance.Size = new Size(177, 59);
            Balance.TabIndex = 0;
            Balance.Text = "Check Balance";
            Balance.UseVisualStyleBackColor = false;
            Balance.Click += button1_Click;

            Deposit.BackColor = Color.Red;
            Deposit.Location = new Point(12, 77);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(177, 59);
            Deposit.TabIndex = 1;
            Deposit.Text = "Depsoit";
            Deposit.UseVisualStyleBackColor = false;
            Deposit.Click += Deposit_Click;

            Withdraw.BackColor = Color.FromArgb(192, 192, 0);
            Withdraw.Location = new Point(12, 142);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(177, 59);
            Withdraw.TabIndex = 2;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = false;
            Withdraw.Click += Withdraw_Click;

            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);

            WithdrawAmount.Location = new Point(195, 161);
            WithdrawAmount.Name = "WithdrawAmount";
            WithdrawAmount.Size = new Size(100, 23);
            WithdrawAmount.TabIndex = 4;

            DepositAmount.Location = new Point(195, 96);
            DepositAmount.Name = "DepositAmount";
            DepositAmount.Size = new Size(100, 23);
            DepositAmount.TabIndex = 5;

            Amount.AutoSize = true;
            Amount.ForeColor = Color.Blue;
            Amount.Location = new Point(190, 143);
            Amount.Name = "Amount";
            Amount.Size = new Size(105, 15);
            Amount.TabIndex = 6;
            Amount.Text = "Withdraw Amount";
            Amount.Click += label1_Click;

            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(195, 77);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 7;
            label1.Text = "Depsoit Amount";

            BalanceCheck.AccessibleRole = AccessibleRole.TitleBar;
            BalanceCheck.AutoSize = true;
            BalanceCheck.ForeColor = Color.Blue;
            BalanceCheck.Location = new Point(220, 34);
            BalanceCheck.Name = "BalanceCheck";
            BalanceCheck.Size = new Size(0, 15);
            BalanceCheck.TabIndex = 8;

            BalanceAmount.AutoSize = true;
            BalanceAmount.ForeColor = Color.Blue;
            BalanceAmount.Location = new Point(190, 34);
            BalanceAmount.Name = "BalanceAmount";
            BalanceAmount.Size = new Size(130, 15);
            BalanceAmount.TabIndex = 9;
            BalanceAmount.Text = "Last Checked Amount: ";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 364);
            Controls.Add(BalanceAmount);
            Controls.Add(BalanceCheck);
            Controls.Add(label1);
            Controls.Add(Amount);
            Controls.Add(DepositAmount);
            Controls.Add(WithdrawAmount);
            Controls.Add(Withdraw);
            Controls.Add(Deposit);
            Controls.Add(Balance);
            Name = "FormMain";
            Text = "ATM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Balance;
        private Button Deposit;
        private Button Withdraw;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox WithdrawAmount;
        private TextBox DepositAmount;
        private Label Amount;
        private Label label1;
        private Label BalanceCheck;
        private Label BalanceAmount;
    }
}
