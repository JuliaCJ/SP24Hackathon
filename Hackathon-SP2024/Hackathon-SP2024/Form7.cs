using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_SP2024
{
    public partial class Form7 : Form
    {
        AccountManager man;
        public Form7(AccountManager man)
        {
            InitializeComponent();
            this.man = man;
        }


        private void CreateAccount_Click_1(object sender, EventArgs e)
        {
            man.addPerson(NewName.Text, NewUser.Text, NewPass.Text, NewEmail.Text, NewPhone.Text, NewGender.Text, BdayBox.Text);
            man.saveAccounts();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
