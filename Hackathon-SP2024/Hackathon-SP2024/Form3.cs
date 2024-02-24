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
    public partial class Form3 : Form
    {
        List<bool> list;

        /*List Order:
         * shelter
         * bank
         * haven
         * rehab
         * medical
         */

        List<Helper> allHelpers;
        AccountManager man;
        Person acc;
        string city;

        public Form3(AccountManager man, Person acc, List<bool> list, string city)
        {
            InitializeComponent();
             this.man = man;
            this.acc = acc;
            this.list = list;
            this.city = city;
            this.allHelpers = man.getHelpers();
            ListLocations();
           
        }

        public void ListLocations()
        {
            foreach(Helper h in allHelpers)
            {
                if (h.getAddress().Contains(city) && ((h.getDes().Contains("Shelter") && list[0]) || (h.getDes().Contains("Bank") && list[1]) || (h.getDes().Contains("Haven") && list[2]) || (h.getDes().Contains("Rehab") && list[3])|| (h.getDes().Contains("Medical") && list[4])))
                {
                    LocationListLabel.Text += h.ToString() + "\n\n";
                }
                
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(man, acc);
            form2.Show();
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
