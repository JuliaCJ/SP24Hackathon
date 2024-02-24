using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hackathon_SP2024
{
   
    public partial class Form5 : Form
    {
        AccountManager man;
        Helper acc;
        public Form5(AccountManager man, Helper acc)
        {
            InitializeComponent();
            this.man = man;
            this.acc = acc;

            NameLabel.Text = "Name: " + acc.getName();
            UserLabel.Text = "Username: " + acc.getUser();
            EmailLabel.Text = "Email: " + acc.getEmail();
            PhoneLabel.Text = "Phone: " + acc.getPhone();
            DesLabel.Text = acc.prettyDes();
            CurrLabel.Text = "Current Capacity: " + acc.getCurrent();
            MaxCapLabel.Text = "Maximum Capacity: " + acc.getCap();
            PerLabel.Text = "Percent Full: " + acc.getPercentFull();
            LimitLabel.Text = "Limits: " + acc.getLimits();
            AdrsLabel.Text = acc.prettyAdrs();
            HoursLabel.Text = "Hours: " + acc.getHours();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewName.Text))
            {
                acc.setName(NewName.Text);
            }
            if(!string.IsNullOrEmpty(NewUser.Text))
            {
                acc.setUser(NewUser.Text);
            }
            if (!string.IsNullOrEmpty(NewPass.Text))
            {
                acc.setPass(NewPass.Text);
            }
            if(!string.IsNullOrEmpty(NewEmail.Text))
            {
                acc.setEmail(NewEmail.Text);
            }
            if(!string.IsNullOrEmpty(NewPhone.Text))
            {
                acc.setPhone(NewPhone.Text);
            }
            
            if(ShelterBox.Checked || HavenBox.Checked || BankBox.Checked || RehabBox.Checked || MedBox.Checked)
            {
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

                acc.setDes(newDes);

            }
            if (!string.IsNullOrEmpty(LimitBox.Text))
            {
                acc.setLimits(LimitBox.Text);
            }
            if (!string.IsNullOrEmpty(MaxCapBox.Text))
            {
                acc.setCap(Convert.ToInt32(MaxCapBox.Text));
            }
            if (!string.IsNullOrEmpty(CurrentBox.Text))
            {
                acc.setCurrent(Convert.ToInt32(CurrentBox.Text));
            }

            if (!string.IsNullOrEmpty(Street.Text) && !string.IsNullOrEmpty(CityBox.Text) && !string.IsNullOrEmpty(ZipBox.Text))
            {
                string adrs = Street.Text + ";" + ZipBox.Text + ";";
                if (AprtBox.Text != null)
                {
                    adrs += AprtBox.Text + ";";
                }
                adrs += ZipBox;
                acc.setAddress(adrs);
            }

            if (!string.IsNullOrEmpty(HoursBox.Text)) 
            {
                acc.setHours(HoursBox.Text);
            }

            man.saveAccounts();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

      
    }
}
