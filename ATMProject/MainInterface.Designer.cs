﻿namespace ATMProject
{
    partial class MainInterface
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
            this.WCashButton = new System.Windows.Forms.Button();
            this.CBalanceButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ButtonFor10p = new System.Windows.Forms.Button();
            this.buttonfor50 = new System.Windows.Forms.Button();
            this.buttonfor500 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WCashButton
            // 
            this.WCashButton.Location = new System.Drawing.Point(69, 261);
            this.WCashButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WCashButton.Name = "WCashButton";
            this.WCashButton.Size = new System.Drawing.Size(143, 29);
            this.WCashButton.TabIndex = 0;
            this.WCashButton.Text = "Withdraw Cash";
            this.WCashButton.UseVisualStyleBackColor = true;
            this.WCashButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBalanceButton
            // 
            this.CBalanceButton.Location = new System.Drawing.Point(69, 331);
            this.CBalanceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBalanceButton.Name = "CBalanceButton";
            this.CBalanceButton.Size = new System.Drawing.Size(143, 29);
            this.CBalanceButton.TabIndex = 1;
            this.CBalanceButton.Text = "Check Balance";
            this.CBalanceButton.UseVisualStyleBackColor = true;
            this.CBalanceButton.Click += new System.EventHandler(this.CBalanceButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(69, 400);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(143, 29);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ButtonFor10p
            // 
            this.ButtonFor10p.Location = new System.Drawing.Point(294, 261);
            this.ButtonFor10p.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonFor10p.Name = "ButtonFor10p";
            this.ButtonFor10p.Size = new System.Drawing.Size(84, 29);
            this.ButtonFor10p.TabIndex = 3;
            this.ButtonFor10p.Text = "£10";
            this.ButtonFor10p.UseVisualStyleBackColor = true;
            this.ButtonFor10p.Click += new System.EventHandler(this.ButtonFor10p_Click);
            // 
            // buttonfor50
            // 
            this.buttonfor50.Location = new System.Drawing.Point(294, 331);
            this.buttonfor50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonfor50.Name = "buttonfor50";
            this.buttonfor50.Size = new System.Drawing.Size(84, 29);
            this.buttonfor50.TabIndex = 6;
            this.buttonfor50.Text = "£50";
            this.buttonfor50.UseVisualStyleBackColor = true;
            // 
            // buttonfor500
            // 
            this.buttonfor500.Location = new System.Drawing.Point(294, 400);
            this.buttonfor500.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonfor500.Name = "buttonfor500";
            this.buttonfor500.Size = new System.Drawing.Size(84, 29);
            this.buttonfor500.TabIndex = 9;
            this.buttonfor500.Text = "£500";
            this.buttonfor500.UseVisualStyleBackColor = true;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 741);
            this.Controls.Add(this.buttonfor500);
            this.Controls.Add(this.buttonfor50);
            this.Controls.Add(this.ButtonFor10p);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CBalanceButton);
            this.Controls.Add(this.WCashButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainInterface";
            this.Text = "ATM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WCashButton;
        private System.Windows.Forms.Button CBalanceButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ButtonFor10p;
        private System.Windows.Forms.Button buttonfor50;
        private System.Windows.Forms.Button buttonfor500;
    }
}