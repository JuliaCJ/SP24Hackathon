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
    public partial class Form6 : Form
    {
        AccountManager man;
        public Form6(AccountManager man)
        {
            InitializeComponent();
            this.man = man;
        }

        private void PersonButton_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(man);
            form7.Show();
            this.Hide();
        }

        private void HelperButton_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(man);
            form8.Show();
            this.Hide();
        }
    }
}
