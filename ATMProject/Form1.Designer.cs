namespace ATMProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWithRace = new System.Windows.Forms.Button();
            this.btnWithoutRace = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnWithdrawCash = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBxPinLogin = new System.Windows.Forms.TextBox();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.btnConfirmPin = new System.Windows.Forms.Button();
            this.btnConfirmAccNum = new System.Windows.Forms.Button();
            this.lblConfirmAccNum = new System.Windows.Forms.Label();
            this.txtBxAccNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWithRace
            // 
            this.btnWithRace.Location = new System.Drawing.Point(340, 202);
            this.btnWithRace.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithRace.Name = "btnWithRace";
            this.btnWithRace.Size = new System.Drawing.Size(134, 19);
            this.btnWithRace.TabIndex = 0;
            this.btnWithRace.Text = "With Race Conditions";
            this.btnWithRace.UseVisualStyleBackColor = true;
            this.btnWithRace.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWithoutRace
            // 
            this.btnWithoutRace.Location = new System.Drawing.Point(340, 243);
            this.btnWithoutRace.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithoutRace.Name = "btnWithoutRace";
            this.btnWithoutRace.Size = new System.Drawing.Size(134, 19);
            this.btnWithoutRace.TabIndex = 1;
            this.btnWithoutRace.Text = "Without Race Conditions";
            this.btnWithoutRace.UseVisualStyleBackColor = true;
            this.btnWithoutRace.Click += new System.EventHandler(this.btnWithoutRace_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(276, 265);
            this.btn500.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(56, 19);
            this.btn500.TabIndex = 15;
            this.btn500.Text = "£500";
            this.btn500.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(276, 220);
            this.btn50.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(56, 19);
            this.btn50.TabIndex = 14;
            this.btn50.Text = "£50";
            this.btn50.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(276, 175);
            this.btn10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(56, 19);
            this.btn10.TabIndex = 13;
            this.btn10.Text = "£10";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(126, 265);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 19);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(126, 220);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(95, 19);
            this.btnCheckBalance.TabIndex = 11;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnWithdrawCash
            // 
            this.btnWithdrawCash.Location = new System.Drawing.Point(126, 175);
            this.btnWithdrawCash.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWithdrawCash.Name = "btnWithdrawCash";
            this.btnWithdrawCash.Size = new System.Drawing.Size(95, 19);
            this.btnWithdrawCash.TabIndex = 10;
            this.btnWithdrawCash.Text = "Withdraw Cash";
            this.btnWithdrawCash.UseVisualStyleBackColor = true;
            this.btnWithdrawCash.Click += new System.EventHandler(this.btnWithdrawCash_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(519, 181);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 16;
            this.lblBalance.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBxPinLogin
            // 
            this.txtBxPinLogin.Location = new System.Drawing.Point(322, 128);
            this.txtBxPinLogin.Name = "txtBxPinLogin";
            this.txtBxPinLogin.Size = new System.Drawing.Size(100, 20);
            this.txtBxPinLogin.TabIndex = 17;
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Location = new System.Drawing.Point(185, 128);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(106, 13);
            this.lblEnterPin.TabIndex = 18;
            this.lblEnterPin.Text = "Please enter your pin";
            // 
            // btnConfirmPin
            // 
            this.btnConfirmPin.Location = new System.Drawing.Point(452, 123);
            this.btnConfirmPin.Name = "btnConfirmPin";
            this.btnConfirmPin.Size = new System.Drawing.Size(116, 25);
            this.btnConfirmPin.TabIndex = 19;
            this.btnConfirmPin.Text = "Confirm Pin";
            this.btnConfirmPin.UseVisualStyleBackColor = true;
            this.btnConfirmPin.Click += new System.EventHandler(this.btnConfirmPin_Click);
            // 
            // btnConfirmAccNum
            // 
            this.btnConfirmAccNum.Location = new System.Drawing.Point(452, 175);
            this.btnConfirmAccNum.Name = "btnConfirmAccNum";
            this.btnConfirmAccNum.Size = new System.Drawing.Size(181, 25);
            this.btnConfirmAccNum.TabIndex = 22;
            this.btnConfirmAccNum.Text = "Confirm Account Number";
            this.btnConfirmAccNum.UseVisualStyleBackColor = true;
            this.btnConfirmAccNum.Click += new System.EventHandler(this.btnConfirmAccNum_Click);
            // 
            // lblConfirmAccNum
            // 
            this.lblConfirmAccNum.AutoSize = true;
            this.lblConfirmAccNum.Location = new System.Drawing.Point(144, 183);
            this.lblConfirmAccNum.Name = "lblConfirmAccNum";
            this.lblConfirmAccNum.Size = new System.Drawing.Size(172, 13);
            this.lblConfirmAccNum.TabIndex = 21;
            this.lblConfirmAccNum.Text = "Please enter your Account Number\r\n";
            // 
            // txtBxAccNum
            // 
            this.txtBxAccNum.Location = new System.Drawing.Point(322, 180);
            this.txtBxAccNum.Name = "txtBxAccNum";
            this.txtBxAccNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxAccNum.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmAccNum);
            this.Controls.Add(this.lblConfirmAccNum);
            this.Controls.Add(this.txtBxAccNum);
            this.Controls.Add(this.btnConfirmPin);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.txtBxPinLogin);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnWithdrawCash);
            this.Controls.Add(this.btnWithoutRace);
            this.Controls.Add(this.btnWithRace);
            this.Name = "Form1";
            this.Text = "ATM-Threading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithRace;
        private System.Windows.Forms.Button btnWithoutRace;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnWithdrawCash;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBxPinLogin;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.Button btnConfirmPin;
        private System.Windows.Forms.Button btnConfirmAccNum;
        private System.Windows.Forms.Label lblConfirmAccNum;
        private System.Windows.Forms.TextBox txtBxAccNum;
    }
}

