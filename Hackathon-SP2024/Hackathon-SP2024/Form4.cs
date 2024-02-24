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
    public partial class Form4 : Form
    {
        AccountManager man;
        Person acc;
        public Form4(AccountManager man, Person acc)
        {
            InitializeComponent();
            this.man = man;
            this.acc = acc;
            
            NameLabel.Text = "Name: " + acc.getName();
            UserLabel.Text = "Username: " + acc.getUser();
            PhoneLabel.Text = "Phone: " + acc.getPhone();
            EmailLabel.Text = "Email: " + acc.getEmail();
            BdayLabel.Text = "Birthday: " + acc.getBday();
            GenLabel.Text = "Gender: " + acc.getGender();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewName.Text))
            {
                acc.setName(NewName.Text);
            }
            if (!string.IsNullOrEmpty(NewUser.Text))
            {
                acc.setUser(NewUser.Text);
            }
            if (!string.IsNullOrEmpty(NewPass.Text))
            {
                acc.setPass(NewPass.Text);
            }
            if (!string.IsNullOrEmpty(NewEmail.Text))
            {
                acc.setEmail(NewEmail.Text);
            }
            if (!string.IsNullOrEmpty(NewGender.Text))
            {
                acc.serGender(NewGender.Text);
            }
            if (!string.IsNullOrEmpty(NewPhone.Text))
            {
                acc.setPhone(NewPhone.Text);
            }
            man.saveAccounts();
            Form2 form2 = new Form2(man, acc);
            form2.Show();
            this.Hide();

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(man, acc);
            form2.Show();
            this.Hide();

        }
    }

        
}
