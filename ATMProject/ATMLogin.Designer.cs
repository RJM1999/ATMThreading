namespace ATMProject
{
    partial class ATMLogin
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
            this.lblAccNum = new System.Windows.Forms.Label();
            this.txtBxAccNum = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.txtBxPIN = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Location = new System.Drawing.Point(139, 138);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(169, 13);
            this.lblAccNum.TabIndex = 0;
            this.lblAccNum.Text = "Please enter your account number";
            // 
            // txtBxAccNum
            // 
            this.txtBxAccNum.Location = new System.Drawing.Point(326, 135);
            this.txtBxAccNum.Name = "txtBxAccNum";
            this.txtBxAccNum.Size = new System.Drawing.Size(172, 20);
            this.txtBxAccNum.TabIndex = 1;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(142, 171);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(110, 13);
            this.lblPIN.TabIndex = 2;
            this.lblPIN.Text = "Please enter your PIN";
            // 
            // txtBxPIN
            // 
            this.txtBxPIN.Location = new System.Drawing.Point(326, 173);
            this.txtBxPIN.Name = "txtBxPIN";
            this.txtBxPIN.Size = new System.Drawing.Size(171, 20);
            this.txtBxPIN.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(307, 219);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 44);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Open an ATM";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ATMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBxPIN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.txtBxAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Name = "ATMLogin";
            this.Text = "ATMLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.TextBox txtBxAccNum;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox txtBxPIN;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}