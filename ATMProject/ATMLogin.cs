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
    public partial class ATMLogin : Form
    {
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
                    ATMForm form = new ATMForm(Program.returnAccount(accountNum, pinNum));
                    form.Show();
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
    }
}
