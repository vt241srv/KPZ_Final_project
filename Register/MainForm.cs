using Register.Core;
using Register.Data;

namespace Register
{
    public partial class MainForm : Form
    {
        private AutomatedTellerMachine _atm;

        public MainForm()
        {
            InitializeComponent();
            InitializeAtmLogic();
        }

        private void InitializeAtmLogic()
        {

            var repository = new JsonAccountRepository("accounts.json");
            _atm = new AutomatedTellerMachine(repository);

            _atm.OnAuthenticationResult += HandleAuthResult;
            _atm.OnBalanceRequested += HandleBalanceRequested;
            _atm.OnTransferResult += HandleTransferResult;
        }


        private void HandleAuthResult(bool isSuccess, string message)
        {
            if (isSuccess)
            {
                MessageBox.Show(message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlLogin.Visible = false;
                pnlOperations.Visible = true;

                _atm.RequestBalance();
            }
            else
            {
                MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleBalanceRequested(decimal balance)
        {
            lblBalance.Text = $"Ваш баланс: {balance} грн";
        }

        private void HandleTransferResult(bool isSuccess, string message)
        {
            if (isSuccess)
            {
                MessageBox.Show(message, "Переказ успішний", MessageBoxButtons.OK, MessageBoxIcon.Information);
               _atm.RequestBalance();
                txtTargetCard.Clear();
                txtAmount.Clear();
            }
            else
            {
                MessageBox.Show(message, "Помилка переказу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            _atm.Authenticate(txtCardNumber.Text, txtPin.Text);
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            _atm.RequestBalance();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                _atm.TransferFunds(txtTargetCard.Text, amount);
            }
            else
            {
                MessageBox.Show("Введіть коректну суму цифрами!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _atm.Logout();
            pnlOperations.Visible = false;
            pnlLogin.Visible = true;

            txtCardNumber.Clear();
            txtPin.Clear();
            lblBalance.Text = "Ваш баланс: 0 грн";
        }

    }
}
