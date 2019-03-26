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
    }
}
