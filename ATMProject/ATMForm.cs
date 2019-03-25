using System;
using System.Windows.Forms;
using System.Threading;

namespace ATMProject
{
    public partial class ATMForm : Form
    {
        private Account activeAccount;

        public ATMForm()
        {
            InitializeComponent();          
        }

        public ATMForm(Account loginAccount)
        {
            activeAccount = loginAccount;
            InitializeComponent();
        }

        private void ATMForm_Load(object sender, EventArgs e)
        {

        }

        private void hideAllElements()
        {
            btnCheckBalance.Visible = false;
            btnExit.Visible = false;
            btnWithdrawCash.Visible = false;
            btn10.Visible = false;
            btn50.Visible = false;
            btn500.Visible = false;
            lblBalance.Visible = false;
            lblWelcomeMsg.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the program
            Close();
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            btn10.Visible = true;
            btn50.Visible = true;
            btn500.Visible = true;
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            lblBalance.Text = "Your balance is £" + activeAccount.getBalance().ToString();
            lblBalance.Visible = true;
        }

        private void showAccountScreen()
        {
            //Hide all elements
            hideAllElements();

            lblWelcomeMsg.Visible = true;

            btnCheckBalance.Visible = true;
            btnWithdrawCash.Visible = true;
            btnExit.Visible = true;
        }


        private void btn10_Click(object sender, EventArgs e)
        {
            if(activeAccount.getBalance() < 10)
            {
                MessageBox.Show("You dont have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You have widthdrawn £10");
                activeAccount.decrementBalance(10);
            }

        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (activeAccount.getBalance() < 50)
            {
                MessageBox.Show("You dont have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You have widthdrawn £50");
                activeAccount.decrementBalance(50);
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (activeAccount.getBalance() < 500)
            {
                MessageBox.Show("You dont have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You have widthdrawn £500");
                activeAccount.decrementBalance(500);
            }
        }
    }
}



