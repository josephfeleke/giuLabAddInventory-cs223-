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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = txt_name.Text;
            product.price = Convert.ToInt32(txt_price.Text);
            product.itemName = txt_ItemName.Text;
            product.count = int.Parse(txt_price.Text);
            product.date = dateTimePicker.Value;
            product.inventoryNumber = Convert.ToInt32(txt_inventoryNumber.Text);
            MessageBox.Show(product.save());


        }
    }
}
