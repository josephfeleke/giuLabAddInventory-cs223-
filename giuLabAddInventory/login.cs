using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giuLabAddInventory
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "1234" && txt_username.Text == "admin")
            {
                Form1 form = new Form1(txt_username.Text);
                form.Show();
                this.Hide();
            }
        }
    }
}
