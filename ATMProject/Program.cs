using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    static class Program
    {
        static Boolean raceConditions;
        static Account[] Accounts;

        public static void setRaceConditions(Boolean input)
        {
            raceConditions = input;
        }

        public static Account returnAccount(int accNum, int PIN)
        {
            for(int i = 0; i < Accounts.Length; i++)
            {
                if(Accounts[i].getAccountNum() == accNum && Accounts[i].getPin() == PIN)
                {
                    return Accounts[i];
                }
            }

            return null;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Account[] ac = new Account[3];

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            Accounts = ac;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATMStartScreen());
        }
    }

    
}

