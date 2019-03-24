using System;
using System.Windows.Forms;
using System.Threading;

namespace ATMProject
{
    public partial class ATMForm : Form
    {
        //Variables for class
        Account[] ac = new Account[3];
        ATM atm;
        Thread atm1;
        Thread atm2;
        ThreadStart threadStart;
        ATMForm secondFrom;
        Boolean raceCondition;
        delegate void getbalance();

        public ATMForm()
        {
            InitializeComponent();

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
            atm = new ATM(ac);
            atm1 = new Thread(()=>showRaceConditions());
            atm1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Start the program and get the race conditions
            showRaceConditions();
        }

        private void showRaceConditions()
        {
            //Hide everything but race conditions buttons
            hideAllElements();
            this.Invoke((MethodInvoker)delegate
            {
                btnWithoutRace.Visible = true;
                btnWithRace.Visible = true;
            });
        }

        private void hideAllElements()
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }

            this.Invoke((MethodInvoker)delegate
            {
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
                btnWithRace.Visible = false;
                btnWithoutRace.Visible = false;
                lblWelcomeMsg.Visible = false;
            });
        }


        private void btnWithRace_Click(object sender, EventArgs e)
        {
            //raceCondition condition wanted
            raceCondition = true;
            startThreads();

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
            lblBalance.Text = "Your balance is £" + atm.getActiveAccount().getBalance().ToString();
            lblBalance.Visible = true;
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
            /*
            firstForm = new ATMForm();
            firstForm.Show();
            */
            secondFrom = new ATMForm();
            secondFrom.Show();
            threadStart = secondFrom.showAccNumInput;
            atm2 = new System.Threading.Thread(new System.Threading.ThreadStart(threadStart));
            atm2.Start();
        }

        private void showAccNumInput()
        {
            //Hide all
            hideAllElements();

            //Show account number buttons
            this.Invoke((MethodInvoker)delegate
            {
                lblConfirmAccNum.Visible = true;
                txtBxAccNum.Visible = true;
                btnConfirmAccNum.Visible = true;
            });
        }

        private void showPinInput()
        {
            //Hide all
            hideAllElements();

            //Show pin enter buttons
            this.Invoke((MethodInvoker)delegate
            {
                lblEnterPin.Visible = true;
                txtBxPinLogin.Visible = true;
                btnConfirmPin.Visible = true;
            });
        }

       

        private void btnConfirmPin_Click(object sender, EventArgs e)
        {
            //Pin num
            int pinNum;

            //Make sure the text box has something in it
            if(string.IsNullOrWhiteSpace(txtBxPinLogin.Text) == true)
            {
                Console.WriteLine("Textbox is empty");
            }
            else
            {
                //Get pin number
                pinNum = Convert.ToInt32(txtBxPinLogin.Text);

                if(atm.getActiveAccountPin() == pinNum)
                {
                    //Debug msg
                    Console.WriteLine("Correct PIN entered");

                    //Show account screen
                    showAccountScreen();
                }
                else
                {
                    //Debug msg
                    Console.WriteLine("Wrong pin");

                    //Error message for user
                    MessageBox.Show("Incorrect PIN entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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


        private void btnConfirmAccNum_Click(object sender, EventArgs e)
        {
            //Acc num
            int accountNum;
            int check = 1;
            //Make sure the text box has some values in it
            if (string.IsNullOrWhiteSpace(txtBxAccNum.Text) == true)
            {
                Console.WriteLine("Textbox is empty");
            }
            else
            {
                //Get the account number
                accountNum = Convert.ToInt32(txtBxAccNum.Text);

                for (int i = 0; i < atm.getNumOfAccounts(); i++)
                {
                    if (atm.getAccount(i).getAccountNum() == accountNum) //Found the correct account
                    {
                        //Set the active account to the one we have found
                        atm.setActiveAccount(atm.getAccount(i));

                        MessageBox.Show("Account has been found and is now the active account");

                        //Exit out the current loop as we have got the account we need

                        //Enter pin
                        check = 0;
                        showPinInput();

                        break;
                    }
                    else //Otherwise
                    {
                        //Move on
                        
                    }                   
                }
                if(check == 1)
                {
                    MessageBox.Show("Account not found, Please try again");
                }
                
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if(atm.getActiveAccount().getBalance() < 10)
            {
                MessageBox.Show("You dont have enough funds");
            }
            else
            {
                MessageBox.Show("You have widthdrawn £10");
                atm.getActiveAccount().decrementBalance(10);
                //secondFrom.atm.getActiveAccount().decrementBalance(10);
            }

        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (atm.getActiveAccount().getBalance() < 50)
            {
                MessageBox.Show("You dont have enough funds");
            }
            else
            {
                MessageBox.Show("You have widthdrawn £50");
                atm.getActiveAccount().decrementBalance(50);
                //secondFrom.atm.getActiveAccount().decrementBalance(50);
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (atm.getActiveAccount().getBalance() < 500)
            {
                MessageBox.Show("You dont have enough funds");
            }
            else
            {
                MessageBox.Show("You have widthdrawn £500");
                atm.getActiveAccount().decrementBalance(500);
                //secondFrom.atm.getActiveAccount().decrementBalance(500);
            }
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
        public Boolean decrementBalance(int amount)
        {
            if (this.balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return true;
            }
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

        public Account getActiveAccount()
        {
            return activeAccount;
        }

        public int getNumOfAccounts()
        {
            //Return the size of the account array
            return this.ac.GetLength(0);
        }

        public void setActiveAccount(Account newActiveAccount)
        {
            activeAccount = newActiveAccount;
        }

        public int getActiveAccountPin()
        {
            //Retuern the active accounts pin for validation
            return activeAccount.getPin();
        }

    }
}



