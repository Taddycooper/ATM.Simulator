using System;
using System.Globalization;
using System.Windows.Forms;

namespace ATM.Simulator
{
    public partial class FormMain : Form
    {
        private decimal _balance;

        public FormMain()
        {
            InitializeComponent();
            _balance = 1000.00m;
            UpdateBalanceDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBalanceDisplay();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            if (!TryParseAmount(DepositAmount.Text, out var amount))
            {
                MessageBox.Show("Invalid deposit amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Enter a positive amount to deposit.", "Invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _balance += amount;
            UpdateBalanceDisplay();
            MessageBox.Show($"Deposited {amount.ToString("C", CultureInfo.CurrentCulture)}.", "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DepositAmount.Clear();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (!TryParseAmount(WithdrawAmount.Text, out var amount))
            {
                MessageBox.Show("Invalid withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Enter a positive amount to withdraw.", "Invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amount > _balance)
            {
                MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _balance -= amount;
            UpdateBalanceDisplay();
            MessageBox.Show($"Withdrew {amount.ToString("C", CultureInfo.CurrentCulture)}.", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            WithdrawAmount.Clear();
        }

        private bool TryParseAmount(string text, out decimal amount)
        {
            return decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out amount);
        }

        private void UpdateBalanceDisplay()
        {
            BalanceCheck.Text = $"Current Balance: {_balance.ToString("C", CultureInfo.CurrentCulture)}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
