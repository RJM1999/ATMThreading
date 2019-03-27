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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions for our ATM Threading assignment \n \n"
                + "Upon launching the program a form appears with 2 buttons, Run the program with or without race conditions. If you run the program with race conditions a data race will occur when opening 2 terminals with the " +
                "same account number, otherwise no data race will occur.When running with a data race it is advised you open 2 ATMs with the same account number and then withdraw money on 1 ATM then it will wait until " +
                "you withdraw on the other ATM then Check the balance and there will be a inconsistency in the funds available in the account. \n \n " +
                "If without race conditions is ran another form appears for a semaphore test, " +
                "if you run the program with this and you have logged into 2 ATMs with the same account number, one ATM will stop until an amount is withdrawn from the" +
                " other ATM.You can then check the balance and the correct balance will appear. \n \n" +
                "If you wish to run more than 2 ATMs with different account numbers please run: Run without race conditions -> Run without semaphore test and you can run as many as you wish.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
