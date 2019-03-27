using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    /*
     *  Group 1 AC22005 ATM Assignment
     *  Ross Maider 170010429
     *  Ryan Crampton 170013546
     */
    public partial class ATMLogin : Form
    {
        //For race conditions
        public static Barrier raceConditionBarrier = new Barrier(2); //Barrier for articifical wait
        public static Semaphore semaphore = new Semaphore(1, 1); //Semaphore to stop race conditions
        public ATMLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Pin
            int pinNum;

            //Account number
            int accountNum;

            //Make sure the text box has something in it
            if (string.IsNullOrWhiteSpace(txtBxPIN.Text) == true || string.IsNullOrWhiteSpace(txtBxAccNum.Text) == true)
            {
                Console.WriteLine("Textboxes are empty");
            }
            else
            {
                //Get pin and account number
                pinNum = Convert.ToInt32(txtBxPIN.Text);
                accountNum = Convert.ToInt32(txtBxAccNum.Text);

                //Check the account exists
                if(Program.returnAccount(accountNum, pinNum) != null)
                {
                    //Create the account management page and show it
                    new Thread(() => new ATMForm(Program.returnAccount(accountNum, pinNum)).ShowDialog()).Start();
                }
                else
                {
                    //Show error message
                    MessageBox.Show("No account was found with the information you provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the program 
            Application.Exit();
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
               "If you wish to run more than 2 ATMs with different account numbers please run: Run without race conditions -> Run without semaphore test and you can run as many as you wish.", "Helps", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
