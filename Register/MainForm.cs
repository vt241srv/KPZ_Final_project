using Register.Core;
using Register.Data;

namespace Register
{
    public partial class MainForm : Form
    {
        private AutomatedTellerMachine _atm;
        private IAccountRepository _repository;
        private string _currentCardNumber;
        public MainForm()
        {
            InitializeComponent();
            InitializeAtmLogic();
        }

        private void InitializeAtmLogic()
        {

            _repository = new JsonAccountRepository("accounts.json");
            _atm = new AutomatedTellerMachine(_repository);

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
            _currentCardNumber = txtCardNumber.Text;
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

        private void btnUpdateHistory_Click(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            lstTransactions.Items.Clear();

            var account = _repository.GetAccountByCardNumber(_currentCardNumber);

            if (account != null && account.Transactions != null)
            {
                for (int i = account.Transactions.Count - 1; i >= 0; i--)
                {
                    lstTransactions.Items.Add(account.Transactions[i].ToString());
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
