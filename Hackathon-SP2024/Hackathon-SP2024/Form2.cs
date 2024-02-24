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
    public partial class Form2 : Form
    {
        Person acc;
        AccountManager man;
        bool shelter;
        bool bank;
        bool safeHaven;
        bool rehab;
        bool medical;

        public Form2(AccountManager man, Person acc)
        {

            InitializeComponent();
            this.acc = acc;
            this.man = man;
            HelloLabel.Text = "Hello, " + acc.getName();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            shelter = Shelter.Checked;
            bank = Bank.Checked;
            safeHaven = Haven.Checked;
            rehab = Rehab.Checked;
            medical = Medical.Checked;

            List<bool> list = new List<bool>() { shelter, bank, safeHaven, rehab, medical };
            Form3 form3 = new Form3(man, acc, list, CityBox.Text);
            form3.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(man, acc);
            form4.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            man.saveAccounts();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

      
    }
}
