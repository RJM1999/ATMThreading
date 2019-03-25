namespace ATMProject
{
    partial class ATMForm
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
            this.btn500 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnWithdrawCash = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblWelcomeMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
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
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
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
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
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
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Location = new System.Drawing.Point(101, 55);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(326, 13);
            this.lblWelcomeMsg.TabIndex = 23;
            this.lblWelcomeMsg.Text = "Welcome to your account, please choose one of the options below.";
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcomeMsg);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnWithdrawCash);
            this.Name = "ATMForm";
            this.Text = "ATM-Threading";
            this.Load += new System.EventHandler(this.ATMForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnWithdrawCash;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblWelcomeMsg;
    }
}

