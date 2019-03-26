namespace ATMProject
{
    partial class ATMStartScreen
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
            this.btnWithSemaTest = new System.Windows.Forms.Button();
            this.btnWithoutSemaTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithRace
            // 
            this.btnWithRace.Location = new System.Drawing.Point(262, 141);
            this.btnWithRace.Name = "btnWithRace";
            this.btnWithRace.Size = new System.Drawing.Size(246, 46);
            this.btnWithRace.TabIndex = 0;
            this.btnWithRace.Text = "Start with Race Conditions";
            this.btnWithRace.UseVisualStyleBackColor = true;
            this.btnWithRace.Click += new System.EventHandler(this.btnwithRace_Click);
            // 
            // btnWithoutRace
            // 
            this.btnWithoutRace.Location = new System.Drawing.Point(263, 204);
            this.btnWithoutRace.Name = "btnWithoutRace";
            this.btnWithoutRace.Size = new System.Drawing.Size(244, 49);
            this.btnWithoutRace.TabIndex = 1;
            this.btnWithoutRace.Text = "Start without Race Conditions";
            this.btnWithoutRace.UseVisualStyleBackColor = true;
            this.btnWithoutRace.Click += new System.EventHandler(this.btnWithoutRace_Click);
            // 
            // btnWithSemaTest
            // 
            this.btnWithSemaTest.Location = new System.Drawing.Point(263, 144);
            this.btnWithSemaTest.Name = "btnWithSemaTest";
            this.btnWithSemaTest.Size = new System.Drawing.Size(242, 43);
            this.btnWithSemaTest.TabIndex = 2;
            this.btnWithSemaTest.Text = "Run with Semaphore Test";
            this.btnWithSemaTest.UseVisualStyleBackColor = true;
            this.btnWithSemaTest.Click += new System.EventHandler(this.btnWithSemaTest_Click);
            // 
            // btnWithoutSemaTest
            // 
            this.btnWithoutSemaTest.Location = new System.Drawing.Point(266, 206);
            this.btnWithoutSemaTest.Name = "btnWithoutSemaTest";
            this.btnWithoutSemaTest.Size = new System.Drawing.Size(238, 46);
            this.btnWithoutSemaTest.TabIndex = 3;
            this.btnWithoutSemaTest.Text = "Run without Semaphore Test";
            this.btnWithoutSemaTest.UseVisualStyleBackColor = true;
            this.btnWithoutSemaTest.Click += new System.EventHandler(this.btnWithoutSemaTest_Click);
            // 
            // ATMStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWithoutSemaTest);
            this.Controls.Add(this.btnWithSemaTest);
            this.Controls.Add(this.btnWithoutRace);
            this.Controls.Add(this.btnWithRace);
            this.Name = "ATMStartScreen";
            this.Text = "startScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithRace;
        private System.Windows.Forms.Button btnWithoutRace;
        private System.Windows.Forms.Button btnWithSemaTest;
        private System.Windows.Forms.Button btnWithoutSemaTest;
    }
}