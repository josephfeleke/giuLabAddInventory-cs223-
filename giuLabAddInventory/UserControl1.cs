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
    public partial class UserControl1 : UserControl
    {

        private string _title;

        public string myTitle
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; label2.Text = value; }
        }
        private string _price;
        public string price
        {
            get { return _price; }
            set { _price = value; label3.Text = value; }
        }
        public UserControl1()
        {
            



        InitializeComponent();
        }
    }
}
