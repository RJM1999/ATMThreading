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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWithRace
            // 
            this.btnWithRace.Location = new System.Drawing.Point(393, 218);
            this.btnWithRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithRace.Name = "btnWithRace";
            this.btnWithRace.Size = new System.Drawing.Size(369, 71);
            this.btnWithRace.TabIndex = 0;
            this.btnWithRace.Text = "Start with Race Conditions";
            this.btnWithRace.UseVisualStyleBackColor = true;
            this.btnWithRace.Click += new System.EventHandler(this.btnwithRace_Click);
            // 
            // btnWithoutRace
            // 
            this.btnWithoutRace.Location = new System.Drawing.Point(395, 314);
            this.btnWithoutRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithoutRace.Name = "btnWithoutRace";
            this.btnWithoutRace.Size = new System.Drawing.Size(366, 75);
            this.btnWithoutRace.TabIndex = 1;
            this.btnWithoutRace.Text = "Start without Race Conditions";
            this.btnWithoutRace.UseVisualStyleBackColor = true;
            this.btnWithoutRace.Click += new System.EventHandler(this.btnWithoutRace_Click);
            // 
            // btnWithSemaTest
            // 
            this.btnWithSemaTest.Location = new System.Drawing.Point(395, 221);
            this.btnWithSemaTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithSemaTest.Name = "btnWithSemaTest";
            this.btnWithSemaTest.Size = new System.Drawing.Size(363, 66);
            this.btnWithSemaTest.TabIndex = 2;
            this.btnWithSemaTest.Text = "Run with Semaphore Test";
            this.btnWithSemaTest.UseVisualStyleBackColor = true;
            this.btnWithSemaTest.Click += new System.EventHandler(this.btnWithSemaTest_Click);
            // 
            // btnWithoutSemaTest
            // 
            this.btnWithoutSemaTest.Location = new System.Drawing.Point(399, 318);
            this.btnWithoutSemaTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithoutSemaTest.Name = "btnWithoutSemaTest";
            this.btnWithoutSemaTest.Size = new System.Drawing.Size(357, 71);
            this.btnWithoutSemaTest.TabIndex = 3;
            this.btnWithoutSemaTest.Text = "Run without Semaphore Test";
            this.btnWithoutSemaTest.UseVisualStyleBackColor = true;
            this.btnWithoutSemaTest.Click += new System.EventHandler(this.btnWithoutSemaTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ATMStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnWithoutSemaTest);
            this.Controls.Add(this.btnWithSemaTest);
            this.Controls.Add(this.btnWithoutRace);
            this.Controls.Add(this.btnWithRace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ATMStartScreen";
            this.Text = "startScreen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithRace;
        private System.Windows.Forms.Button btnWithoutRace;
        private System.Windows.Forms.Button btnWithSemaTest;
        private System.Windows.Forms.Button btnWithoutSemaTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}