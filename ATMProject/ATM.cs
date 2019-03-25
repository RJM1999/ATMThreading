using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
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
