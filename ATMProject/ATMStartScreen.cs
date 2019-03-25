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

            //Make a new login form and then show it
            ATMLogin login = new ATMLogin();
            login.Show();

            //Close current form
            this.Hide();
        }
    }
}
