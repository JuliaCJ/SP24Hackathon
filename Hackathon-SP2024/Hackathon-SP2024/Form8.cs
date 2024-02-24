using Hackathon_SP2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_SP2024
{
    public partial class Form8 : Form
    {
        AccountManager man;
        public Form8(AccountManager man)
        {
            InitializeComponent();
            this.man = man;
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            string name = (NewName.Text);
            
            
            string user = (NewUser.Text);
            
            
            string pass = (NewPass.Text);
            
           
            string email = (NewEmail.Text);
            
           
            string phone = (NewPhone.Text);
            
            string newDes = "";
            if (ShelterBox.Checked)
            {
                newDes += "Homeless Shelter;";
            }
            if (HavenBox.Checked)
            {
                newDes += "Safe Haven;";
            }
            if (BankBox.Checked)
            {
                newDes += "Food Bank;";
            }
            if (RehabBox.Checked)
            {
                newDes += "Rehab Program;";
            }
            if (MedBox.Checked)
            {
                newDes += "Medical Station;";
            }
           
            string limits = (LimitBox.Text);
            
            
            int cap = (Convert.ToInt32(MaxCapBox.Text));
            
        
            int current = (Convert.ToInt32(CurrentBox.Text));
        
            string adrs = Street.Text + ";" + ZipBox.Text + ";";
            if (AprtBox.Text != null)
            {
                adrs += AprtBox.Text + ";";
            }
            adrs += ZipBox.Text;

            string hours = HoursBox.Text;

            man.addHelper(user, pass, name, email, phone, newDes, hours, cap, current, limits, adrs);
            man.saveAccounts();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
