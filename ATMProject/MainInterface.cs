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
    public partial class MainInterface : Form
    {
        private void MainInterface_Load(object sender, EventArgs e)
        {
            Account[] ac = new Account[3];

            ATM atm;

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            atm = new ATM(ac);
        }
        public MainInterface()
        {
            InitializeComponent();
            ButtonFor10p.Hide();
            buttonfor50.Hide();
            buttonfor500.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonFor10p.Show();
            buttonfor50.Show();
            buttonfor500.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFor10p_Click(object sender, EventArgs e)
        {

        }

        private void CBalanceButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

    
