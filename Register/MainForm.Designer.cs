namespace Register
{
    partial class MainForm
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
            pnlLogin = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtPin = new TextBox();
            txtCardNumber = new TextBox();
            pnlOperations = new Panel();
            btnWithdraw = new Button();
            label5 = new Label();
            chkSmallBills = new CheckBox();
            txtWithdrawAmount = new TextBox();
            btnUpdateHistory = new Button();
            lstTransactions = new ListBox();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new Button();
            btnTransfer = new Button();
            lblBalance = new Label();
            btnCheckBalance = new Button();
            txtAmount = new TextBox();
            txtTargetCard = new TextBox();
            pnlAdmin = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnAdminLogout = new Button();
            btnReplenish = new Button();
            txtAdd50 = new TextBox();
            txtAdd100 = new TextBox();
            txtAdd200 = new TextBox();
            txtAdd500 = new TextBox();
            lblVaultStatus = new Label();
            pnlLogin.SuspendLayout();
            pnlOperations.SuspendLayout();
            pnlAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPin);
            pnlLogin.Controls.Add(txtCardNumber);
            pnlLogin.Location = new Point(162, 90);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(150, 156);
            pnlLogin.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "PIN код";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Номер карти";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(24, 111);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Вхід";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPin
            // 
            txtPin.BorderStyle = BorderStyle.FixedSingle;
            txtPin.Location = new Point(3, 69);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(100, 23);
            txtPin.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            txtCardNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCardNumber.Location = new Point(3, 23);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(144, 23);
            txtCardNumber.TabIndex = 0;
            // 
            // pnlOperations
            // 
            pnlOperations.Controls.Add(btnWithdraw);
            pnlOperations.Controls.Add(label5);
            pnlOperations.Controls.Add(chkSmallBills);
            pnlOperations.Controls.Add(txtWithdrawAmount);
            pnlOperations.Controls.Add(btnUpdateHistory);
            pnlOperations.Controls.Add(lstTransactions);
            pnlOperations.Controls.Add(label4);
            pnlOperations.Controls.Add(label3);
            pnlOperations.Controls.Add(btnLogout);
            pnlOperations.Controls.Add(btnTransfer);
            pnlOperations.Controls.Add(lblBalance);
            pnlOperations.Controls.Add(btnCheckBalance);
            pnlOperations.Controls.Add(txtAmount);
            pnlOperations.Controls.Add(txtTargetCard);
            pnlOperations.Location = new Point(12, 48);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(510, 348);
            pnlOperations.TabIndex = 3;
            pnlOperations.Visible = false;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.ActiveCaption;
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.ForeColor = SystemColors.ButtonHighlight;
            btnWithdraw.Location = new Point(41, 297);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(125, 23);
            btnWithdraw.TabIndex = 15;
            btnWithdraw.Text = "Зняти готівку";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(21, 250);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 14;
            label5.Text = "Сума зняття";
            // 
            // chkSmallBills
            // 
            chkSmallBills.AutoSize = true;
            chkSmallBills.ForeColor = SystemColors.ButtonFace;
            chkSmallBills.Location = new Point(199, 270);
            chkSmallBills.Name = "chkSmallBills";
            chkSmallBills.Size = new Size(120, 19);
            chkSmallBills.TabIndex = 13;
            chkSmallBills.Text = "Видати дрібними";
            chkSmallBills.UseVisualStyleBackColor = true;
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.BorderStyle = BorderStyle.FixedSingle;
            txtWithdrawAmount.Location = new Point(21, 268);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(153, 23);
            txtWithdrawAmount.TabIndex = 12;
            // 
            // btnUpdateHistory
            // 
            btnUpdateHistory.BackColor = SystemColors.ActiveCaption;
            btnUpdateHistory.FlatAppearance.BorderSize = 0;
            btnUpdateHistory.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnUpdateHistory.FlatStyle = FlatStyle.Flat;
            btnUpdateHistory.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateHistory.Location = new Point(300, 141);
            btnUpdateHistory.Name = "btnUpdateHistory";
            btnUpdateHistory.Size = new Size(123, 26);
            btnUpdateHistory.TabIndex = 11;
            btnUpdateHistory.Text = "Оновити історію";
            btnUpdateHistory.UseVisualStyleBackColor = false;
            btnUpdateHistory.Click += btnUpdateHistory_Click;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.ItemHeight = 15;
            lstTransactions.Location = new Point(212, 37);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(291, 94);
            lstTransactions.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(26, 77);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "Сума переводу";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(26, 26);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 8;
            label3.Text = "Номер карти отримувача";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaption;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(76, 202);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Вихід";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = SystemColors.ActiveCaption;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.ForeColor = SystemColors.ButtonHighlight;
            btnTransfer.Location = new Point(122, 173);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(75, 23);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Переказати";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.ForeColor = SystemColors.ButtonFace;
            lblBalance.Location = new Point(41, 140);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(38, 15);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "label1";
            // 
            // btnCheckBalance
            // 
            btnCheckBalance.BackColor = SystemColors.ActiveCaption;
            btnCheckBalance.FlatAppearance.BorderSize = 0;
            btnCheckBalance.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCheckBalance.FlatStyle = FlatStyle.Flat;
            btnCheckBalance.ForeColor = SystemColors.ButtonFace;
            btnCheckBalance.Location = new Point(41, 173);
            btnCheckBalance.Name = "btnCheckBalance";
            btnCheckBalance.Size = new Size(75, 23);
            btnCheckBalance.TabIndex = 2;
            btnCheckBalance.Text = "Баланс";
            btnCheckBalance.UseVisualStyleBackColor = false;
            btnCheckBalance.Click += btnCheckBalance_Click;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(26, 93);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(153, 23);
            txtAmount.TabIndex = 1;
            // 
            // txtTargetCard
            // 
            txtTargetCard.BorderStyle = BorderStyle.FixedSingle;
            txtTargetCard.Location = new Point(26, 46);
            txtTargetCard.Name = "txtTargetCard";
            txtTargetCard.Size = new Size(153, 23);
            txtTargetCard.TabIndex = 0;
            // 
            // pnlAdmin
            // 
            pnlAdmin.Controls.Add(label9);
            pnlAdmin.Controls.Add(label8);
            pnlAdmin.Controls.Add(label7);
            pnlAdmin.Controls.Add(label6);
            pnlAdmin.Controls.Add(btnAdminLogout);
            pnlAdmin.Controls.Add(btnReplenish);
            pnlAdmin.Controls.Add(txtAdd50);
            pnlAdmin.Controls.Add(txtAdd100);
            pnlAdmin.Controls.Add(txtAdd200);
            pnlAdmin.Controls.Add(txtAdd500);
            pnlAdmin.Controls.Add(lblVaultStatus);
            pnlAdmin.Location = new Point(15, 12);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(521, 381);
            pnlAdmin.TabIndex = 4;
            pnlAdmin.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(13, 202);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 15;
            label9.Text = "Кількість купюр по 50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(13, 173);
            label8.Name = "label8";
            label8.Size = new Size(133, 15);
            label8.TabIndex = 14;
            label8.Text = "Кількість купюр по 100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(13, 137);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 13;
            label7.Text = "Кількість купюр по 200";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(13, 100);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 12;
            label6.Text = "Кількість купюр по 500";
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.BackColor = SystemColors.ActiveCaption;
            btnAdminLogout.FlatAppearance.BorderSize = 0;
            btnAdminLogout.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnAdminLogout.FlatStyle = FlatStyle.Flat;
            btnAdminLogout.ForeColor = SystemColors.ButtonFace;
            btnAdminLogout.Location = new Point(113, 267);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(172, 23);
            btnAdminLogout.TabIndex = 11;
            btnAdminLogout.Text = "Вийти з режиму Адміна";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // btnReplenish
            // 
            btnReplenish.BackColor = SystemColors.ActiveCaption;
            btnReplenish.FlatAppearance.BorderSize = 0;
            btnReplenish.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnReplenish.FlatStyle = FlatStyle.Flat;
            btnReplenish.ForeColor = SystemColors.ButtonFace;
            btnReplenish.Location = new Point(124, 238);
            btnReplenish.Name = "btnReplenish";
            btnReplenish.Size = new Size(145, 23);
            btnReplenish.TabIndex = 10;
            btnReplenish.Text = "Поповнити банкомат";
            btnReplenish.UseVisualStyleBackColor = false;
            btnReplenish.Click += btnReplenish_Click;
            // 
            // txtAdd50
            // 
            txtAdd50.BorderStyle = BorderStyle.FixedSingle;
            txtAdd50.Location = new Point(148, 199);
            txtAdd50.Name = "txtAdd50";
            txtAdd50.Size = new Size(100, 23);
            txtAdd50.TabIndex = 9;
            // 
            // txtAdd100
            // 
            txtAdd100.BorderStyle = BorderStyle.FixedSingle;
            txtAdd100.Location = new Point(148, 168);
            txtAdd100.Name = "txtAdd100";
            txtAdd100.Size = new Size(100, 23);
            txtAdd100.TabIndex = 8;
            // 
            // txtAdd200
            // 
            txtAdd200.BorderStyle = BorderStyle.FixedSingle;
            txtAdd200.Location = new Point(148, 134);
            txtAdd200.Name = "txtAdd200";
            txtAdd200.Size = new Size(100, 23);
            txtAdd200.TabIndex = 7;
            // 
            // txtAdd500
            // 
            txtAdd500.BorderStyle = BorderStyle.FixedSingle;
            txtAdd500.Location = new Point(148, 97);
            txtAdd500.Name = "txtAdd500";
            txtAdd500.Size = new Size(100, 23);
            txtAdd500.TabIndex = 6;
            // 
            // lblVaultStatus
            // 
            lblVaultStatus.AutoSize = true;
            lblVaultStatus.ForeColor = SystemColors.ButtonFace;
            lblVaultStatus.Location = new Point(317, 97);
            lblVaultStatus.Name = "lblVaultStatus";
            lblVaultStatus.Size = new Size(38, 15);
            lblVaultStatus.TabIndex = 5;
            lblVaultStatus.Text = "label6";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(548, 408);
            Controls.Add(pnlOperations);
            Controls.Add(pnlLogin);
            Controls.Add(pnlAdmin);
            ForeColor = SystemColors.ButtonFace;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlOperations.ResumeLayout(false);
            pnlOperations.PerformLayout();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Button btnLogin;
        private TextBox txtPin;
        private TextBox txtCardNumber;
        private Panel pnlOperations;
        private Button btnLogout;
        private Button btnTransfer;
        private Label lblBalance;
        private Button btnCheckBalance;
        private TextBox txtAmount;
        private TextBox txtTargetCard;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnUpdateHistory;
        private ListBox lstTransactions;
        private Button btnWithdraw;
        private Label label5;
        private CheckBox chkSmallBills;
        private TextBox txtWithdrawAmount;
        private Panel pnlAdmin;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnAdminLogout;
        private Button btnReplenish;
        private TextBox txtAdd50;
        private TextBox txtAdd100;
        private TextBox txtAdd200;
        private TextBox txtAdd500;
        private Label lblVaultStatus;
    }
}
