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
            Program.setRaceConditions(true);
            ATMLogin login = new ATMLogin();
            login.Show();
        }

        private void btnWithoutRace_Click(object sender, EventArgs e)
        {
            Program.setRaceConditions(false);
            ATMLogin login = new ATMLogin();
            login.Show();
        }
    }
}
