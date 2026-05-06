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
            pnlLogin.SuspendLayout();
            pnlOperations.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPin);
            pnlLogin.Controls.Add(txtCardNumber);
            pnlLogin.Location = new Point(56, 74);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(150, 156);
            pnlLogin.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "PIN код";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Номер карти";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(24, 111);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Вхід";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(3, 69);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(100, 23);
            txtPin.TabIndex = 1;
            // 
            // txtCardNumber
            // 
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
            pnlOperations.Location = new Point(240, 52);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(450, 368);
            pnlOperations.TabIndex = 3;
            pnlOperations.Visible = false;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(41, 297);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(125, 23);
            btnWithdraw.TabIndex = 15;
            btnWithdraw.Text = "Зняти готівку";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 250);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 14;
            label5.Text = "Сума зняття";
            // 
            // chkSmallBills
            // 
            chkSmallBills.AutoSize = true;
            chkSmallBills.Location = new Point(199, 270);
            chkSmallBills.Name = "chkSmallBills";
            chkSmallBills.Size = new Size(120, 19);
            chkSmallBills.TabIndex = 13;
            chkSmallBills.Text = "Видати дрібними";
            chkSmallBills.UseVisualStyleBackColor = true;
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.Location = new Point(21, 268);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(153, 23);
            txtWithdrawAmount.TabIndex = 12;
            // 
            // btnUpdateHistory
            // 
            btnUpdateHistory.Location = new Point(233, 140);
            btnUpdateHistory.Name = "btnUpdateHistory";
            btnUpdateHistory.Size = new Size(123, 26);
            btnUpdateHistory.TabIndex = 11;
            btnUpdateHistory.Text = "Оновити історію";
            btnUpdateHistory.UseVisualStyleBackColor = true;
            btnUpdateHistory.Click += btnUpdateHistory_Click;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.ItemHeight = 15;
            lstTransactions.Location = new Point(212, 37);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(212, 94);
            lstTransactions.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 77);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "Сума переводу";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 26);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 8;
            label3.Text = "Номер карти отримувача";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(76, 202);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Вихід";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(122, 173);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(75, 23);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Переказати";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(41, 140);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(38, 15);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "label1";
            // 
            // btnCheckBalance
            // 
            btnCheckBalance.Location = new Point(41, 173);
            btnCheckBalance.Name = "btnCheckBalance";
            btnCheckBalance.Size = new Size(75, 23);
            btnCheckBalance.TabIndex = 2;
            btnCheckBalance.Text = "Баланс";
            btnCheckBalance.UseVisualStyleBackColor = true;
            btnCheckBalance.Click += btnCheckBalance_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(26, 93);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(153, 23);
            txtAmount.TabIndex = 1;
            // 
            // txtTargetCard
            // 
            txtTargetCard.Location = new Point(26, 46);
            txtTargetCard.Name = "txtTargetCard";
            txtTargetCard.Size = new Size(153, 23);
            txtTargetCard.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlOperations);
            Controls.Add(pnlLogin);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlOperations.ResumeLayout(false);
            pnlOperations.PerformLayout();
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
    }
}
