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
    public partial class Form1 : Form
    {
        //Variables for class
        Account[] ac = new Account[3];
        ATM atm;
        Boolean raceCondition;

        public Form1()
        {
            InitializeComponent();

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
            atm = new ATM(ac);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide everything but race conditions buttons
            btnCheckBalance.Visible = false;
            btnExit.Visible = false;
            btnWithdrawCash.Visible = false;
            btn10.Visible = false;
            btn50.Visible = false;
            btn500.Visible = false;
            lblBalance.Visible = false;
            lblEnterPin.Visible = false;
            txtBxPinLogin.Visible = false;
            btnConfirmPin.Visible = false;
            lblConfirmAccNum.Visible = false;
            txtBxAccNum.Visible = false;
            btnConfirmAccNum.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //raceCondition condition wanted
            raceCondition = true;
            startThreads();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the program
            Close();
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnWithoutRace_Click(object sender, EventArgs e)
        {
            //Racecondition not wanted
            raceCondition = false;
            startThreads();
        }

        private void startThreads()
        {
            //Hide race conditions buttons
            btnWithRace.Visible = false;
            btnWithoutRace.Visible = false;

            //Get the account number
            showAccNumInput(); 
            
            //Get PIN Number to confirm user
        }

        private void showAccNumInput()
        {
            //Show account number buttons
            lblConfirmAccNum.Visible = true;
            txtBxAccNum.Visible = true;
            btnConfirmAccNum.Visible = true;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmPin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Acc num
            int accountNum;
            
            //Make sure the text box has some values in it
            if(string.IsNullOrWhiteSpace(txtBxAccNum.Text) == true)
            {

            }
            else
            {
                //Get the account number
                accountNum = Convert.ToInt32(txtBxAccNum.Text);

                for (int i = 0; i < atm.getNumOfAccounts(); i++)
                {
                    if(atm.getAccount(i).getAccountNum() == accountNum) //Found the correct account
                    {

                    }
                }
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }




    class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        public int getAccountNum()
        {
            return this.accountNum;
        }

        public int getPin()
        {
            return this.pin;
        }

    }
    /* 
     *      This is out main ATM class that preforms the actions outlined in the assigment hand out
     *      
     *      the constutor contains the main funcitonality.
     */
    class ATM
    {
        //local referance to the array of accounts
        private Account[] ac;

        //this is a referance to the account that is being used
        private Account activeAccount = null;

        // the atm constructor takes an array of account objects as a referance
        public ATM(Account[] ac)
        {
            this.ac = ac;
        }

        public Account getAccount(int i)
        {
            return ac[i];
        }

        public int getNumOfAccounts()
        {
            //Return the size of the account array
            return this.ac.GetLength(0);
        }

    }
}



