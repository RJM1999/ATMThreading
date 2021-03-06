﻿using System;
using System.Windows.Forms;
using System.Threading;

namespace ATMProject
{
    public partial class ATMForm : Form
    {
        //Fields for the class
        private Account activeAccount; //The account we are currently looking at

        public ATMForm()
        {
            InitializeComponent();          
        }

        public ATMForm(Account loginAccount)
        {
            //Fill the account details in
            activeAccount = loginAccount;
            InitializeComponent();
        }

        private void ATMForm_Load(object sender, EventArgs e)
        {
            //Not an option yet
            hideAllWithdrawOptions();
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
            //Show withdraw options
            showAllWithdrawOptions();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            //Show balance on screen
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

        private void hideAllWithdrawOptions()
        {
            btn10.Visible = false;
            btn50.Visible = false;
            btn500.Visible = false;
        }

        private void showAllWithdrawOptions()
        {
            btn10.Visible = true;
            btn50.Visible = true;
            btn500.Visible = true;
        }


        private void btn10_Click(object sender, EventArgs e)
        {
            if(activeAccount.getBalance() < 10) //Not enough money
            {              
                MessageBox.Show("You dont have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Program.getRaceCon() == true) //Are we looking for race conditions 
                {
                    ATMLogin.raceConditionBarrier.SignalAndWait(); //Wait until 2 withdraws are being attempted 
                    int localbalance = activeAccount.getBalance(); //Make a local balance and get it from the active account
                    localbalance -= 10; //Take away 10
                    activeAccount.setBalance(localbalance); //Set the balance
                }
                else
                {
                    if(Program.getSemaTest() == true)
                    {
                        ATMLogin.raceConditionBarrier.SignalAndWait(); ////Wait until 2 withdraws are being attempted
                    }

                    ATMLogin.semaphore.WaitOne(); //Entering critical code section
                    int localbalance = activeAccount.getBalance(); //Makea local balance and get it from the account
                    localbalance -= 10; //Take away 10
                    activeAccount.setBalance(localbalance); //Update the active accounts balance
                    ATMLogin.semaphore.Release(); //Exit the critical code
                }
                
                MessageBox.Show("You have widthdrawn £10"); //Success message
            }

            hideAllWithdrawOptions(); //Hide the money options

        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (activeAccount.getBalance() < 50) //Not enough money for £50
            {
                MessageBox.Show("You dont have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message
            }
            else
            {
                if (Program.getRaceCon() == true) //Are we looking for race conditions
                {
                    ATMLogin.raceConditionBarrier.SignalAndWait(); //Wait until 2 accounts are attempting a with draw
                    int localbalance = activeAccount.getBalance(); //Make a local balance 
                    localbalance -= 50; //Take away 50
                    activeAccount.setBalance(localbalance); //Update the active account
                }
                else
                {
                    if (Program.getSemaTest() == true)
                    {
                        ATMLogin.raceConditionBarrier.SignalAndWait(); ////Wait until 2 withdraws are being attempted
                    }

                    ATMLogin.semaphore.WaitOne(); //Entering critical code section
                    int localbalance = activeAccount.getBalance(); //Makea local balance and get it from the account
                    localbalance -= 50; //Take away 50
                    activeAccount.setBalance(localbalance); //Update the active accounts balance
                    ATMLogin.semaphore.Release(); //Exit the critical code
                }

                MessageBox.Show("You have widthdrawn £50"); //Sucess message
            }

            hideAllWithdrawOptions();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (activeAccount.getBalance() < 500) //Not enough money
            {
                MessageBox.Show("You dont have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Program.getRaceCon() == true) //Are we looking for race conditions
                {
                    ATMLogin.raceConditionBarrier.SignalAndWait(); //Wait until 2 transactions are attempted 
                    int localbalance = activeAccount.getBalance(); //Make the local balance
                    localbalance -= 500; //Take away 500
                    activeAccount.setBalance(localbalance); //Update the code
                }
                else
                {
                    if (Program.getSemaTest() == true)
                    {
                        ATMLogin.raceConditionBarrier.SignalAndWait(); ////Wait until 2 withdraws are being attempted
                    }

                    ATMLogin.semaphore.WaitOne(); //Entering critical code section
                    int localbalance = activeAccount.getBalance(); //Makea local balance and get it from the account
                    localbalance -= 500; //Take away 500
                    activeAccount.setBalance(localbalance); //Update the active accounts balance
                    ATMLogin.semaphore.Release(); //Exit the critical code
                }

                MessageBox.Show("You have widthdrawn £500"); //Success message
            }

            hideAllWithdrawOptions(); //Hide the options
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