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
    public partial class mainContainer : Form
    {
        public mainContainer()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form activeFroms = this.ActiveMdiChild;
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1("knkj");
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
