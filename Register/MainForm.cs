using Register.Core;
using Register.Data;
using Register.Models;

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

            _atm.OnWithdrawResult += HandleWithdrawResult;
            _atm.OnAuthenticationResult += HandleAuthResult;
            _atm.OnBalanceRequested += HandleBalanceRequested;
            _atm.OnTransferResult += HandleTransferResult;
            _atm.OnAdminAuthResult += HandleAdminAuthResult;
            _atm.OnVaultUpdated += HandleVaultUpdated;
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
            _atm.AuthenticateAdmin(txtCardNumber.Text, txtPin.Text);
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
        private void HandleWithdrawResult(bool isSuccess, string message)
        {
            if (isSuccess)
            {
                MessageBox.Show(message, "Заберіть гроші", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _atm.RequestBalance(); 
                LoadTransactionHistory(); 
                txtWithdrawAmount.Clear();
                chkSmallBills.Checked = false;
            }
            else
            {
                MessageBox.Show(message, "Помилка видачі", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdrawAmount.Text, out decimal amount))
            {
             
                IDispenseStrategy strategy;

                if (chkSmallBills.Checked)
                {
                    strategy = new SmallBillsDispenseStrategy();
                }
                else
                {
                    strategy = new DefaultDispenseStrategy();
                }

                _atm.WithdrawFunds(amount, strategy);
            }
            else
            {
                MessageBox.Show("Введіть коректну суму!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void HandleAdminAuthResult(bool isSuccess)
        {
            if (isSuccess)
            {
                pnlLogin.Visible = false;
                pnlOperations.Visible = false;
                pnlAdmin.Visible = true; 
                MessageBox.Show("Вхід у сервісний режим успішний.", "Admin Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HandleVaultUpdated(AtmVault vault)
        {
            lblVaultStatus.Text = $"Залишок у сейфі: {vault.TotalAmount} грн\n" +
                                  $"500 грн: {vault.Bills500} шт.\n" +
                                  $"200 грн: {vault.Bills200} шт.\n" +
                                  $"100 грн: {vault.Bills100} шт.\n" +
                                  $"50 грн: {vault.Bills50} шт.";
        }

        private void btnReplenish_Click(object sender, EventArgs e)
        {
            int.TryParse(txtAdd500.Text, out int b500);
            int.TryParse(txtAdd200.Text, out int b200);
            int.TryParse(txtAdd100.Text, out int b100);
            int.TryParse(txtAdd50.Text, out int b50);

            _atm.ReplenishVault(b500, b200, b100, b50);

            txtAdd500.Clear(); txtAdd200.Clear(); txtAdd100.Clear(); txtAdd50.Clear();
            MessageBox.Show("Банкомат успішно поповнено!", "Інкасація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            pnlAdmin.Visible = false;
            pnlLogin.Visible = true;
            txtCardNumber.Clear();
            txtPin.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
