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
            btnLogin = new Button();
            txtPin = new TextBox();
            txtCardNumber = new TextBox();
            pnlOperations = new Panel();
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
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPin);
            pnlLogin.Controls.Add(txtCardNumber);
            pnlLogin.Location = new Point(33, 28);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(150, 156);
            pnlLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(24, 111);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "button1";
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
            pnlOperations.Controls.Add(btnLogout);
            pnlOperations.Controls.Add(btnTransfer);
            pnlOperations.Controls.Add(lblBalance);
            pnlOperations.Controls.Add(btnCheckBalance);
            pnlOperations.Controls.Add(txtAmount);
            pnlOperations.Controls.Add(txtTargetCard);
            pnlOperations.Location = new Point(232, 28);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(198, 183);
            pnlOperations.TabIndex = 3;
            pnlOperations.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(59, 140);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "button1";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(105, 111);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(75, 23);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "button1";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(37, 51);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(38, 15);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "label1";
            // 
            // btnCheckBalance
            // 
            btnCheckBalance.Location = new Point(24, 111);
            btnCheckBalance.Name = "btnCheckBalance";
            btnCheckBalance.Size = new Size(75, 23);
            btnCheckBalance.TabIndex = 2;
            btnCheckBalance.Text = "button1";
            btnCheckBalance.UseVisualStyleBackColor = true;
            btnCheckBalance.Click += btnCheckBalance_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(24, 69);
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '*';
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 1;
            // 
            // txtTargetCard
            // 
            txtTargetCard.Location = new Point(24, 23);
            txtTargetCard.Name = "txtTargetCard";
            txtTargetCard.Size = new Size(100, 23);
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
    }
}
