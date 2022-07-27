using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            Regex r = new Regex(@"^[0-9]{2}$");
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Name field is required");
            }
            else
            {
               

                    if (r.IsMatch(txt_count.Text))
                    {
                        errorProvider1.Clear();
                        Product product = new Product();
                        product.name = txt_name.Text;
                        product.price = Convert.ToInt32(txt_price.Text);
                        product.itemName = txt_ItemName.Text;
                        product.count = int.Parse(txt_price.Text);
                        product.date = dateTimePicker.Value;
                        product.inventoryNumber = Convert.ToInt32(txt_inventoryNumber.Text);
                        product.save();
                        MessageBox.Show("Added successfully");
                        mProductGridview.DataSource = null;
                        mProductGridview.DataSource = Product.getAllProducts();
                    }
                    else
                    {
                        errorProvider1.SetError(txt_count, "must be a number");
                    }
                   
               
                
            }


        }
    }
}
