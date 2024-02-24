using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hackathon_SP2024
{
    public partial class Form1 : Form
    {
        AccountManager manager;
        public Form1()
        {
            InitializeComponent();
            
       
            manager = new AccountManager();
            this.Show();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            IncorrectLabel.Text = "";
            bool incorrect = true;
            foreach (Account a in manager.getAccounts()) 
            { 
                if (a.Login(UserBox.Text, PassBox.Text))
                {
                    incorrect = false;
                    if (a is Person)
                    {
                        Form2 form2 = new Form2(manager, (Person)a);
                        form2.Show();
                        this.Hide();
                        break;
                    } else
                    {
                        Form5 form5 = new Form5(manager, (Helper)a);
                        form5.Show();
                        this.Hide();
                        break;
                       
                    }
                }
            }
            
            if (incorrect)
            {
                IncorrectLabel.Text = "Incorrect Username or Password!";
            }

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(manager);   
            form6.Show();
            this.Hide();
        }
    }
}
