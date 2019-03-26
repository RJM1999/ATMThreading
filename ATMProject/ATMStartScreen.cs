using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class ATMStartScreen : Form
    {
        public ATMStartScreen()
        {
            InitializeComponent();
            hideSemaphoreTest();
        }

        private void btnwithRace_Click(object sender, EventArgs e)
        {
            //Set the race conditions
            Program.setRaceConditions(true);

            //Make a new login form and then show it
            ATMLogin login = new ATMLogin();
            login.Show();

            //Close the current form
            this.Hide();
        }

        private void btnWithoutRace_Click(object sender, EventArgs e)
        {
            //Set the race conditons
            Program.setRaceConditions(false);

            //Show semaphore test options
            showSemaphoreTest();
        }

        private void hideAllElements()
        {
            btnWithoutRace.Visible = false;
            btnWithRace.Visible = false;
            btnWithoutSemaTest.Visible = false;
            btnWithSemaTest.Visible = false;
        }

        private void hideSemaphoreTest()
        {
            btnWithSemaTest.Visible = false;
            btnWithoutSemaTest.Visible = false;
        }

        private void showSemaphoreTest()
        {
            hideAllElements();

            btnWithSemaTest.Visible = true;
            btnWithoutSemaTest.Visible = true;
        }

        private void btnWithSemaTest_Click(object sender, EventArgs e)
        {
            //Make a new login form and then show it
            ATMLogin login = new ATMLogin();
            login.Show();

            //Set the semaphore global variable
            Program.setSemaTest(true);

            //Close the current form
            this.Hide();
        }

        private void btnWithoutSemaTest_Click(object sender, EventArgs e)
        {
            //Make a new login form and then show it
            ATMLogin login = new ATMLogin();
            login.Show();

            //Set the semaphore global variable
            Program.setSemaTest(false);

            //Close the current form
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
