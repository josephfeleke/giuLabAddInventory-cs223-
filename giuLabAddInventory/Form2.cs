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
    public partial class Form2 : Form
    {
        List<Product> products = new List<Product>();
        public Form2(List<Product> p)
        {
            products = p;
            InitializeComponent();
            formLoad();
            
        }

        private void formLoad()
        {
            foreach (Product product in products)
            {
                UserControl1 productCard = new UserControl1();
                productCard.myTitle = product.name;
                productCard.Description = product.itemName;
                productCard.price = product.price.ToString();
                productCard.Click += (object o, EventArgs e) =>
                {
                    MessageBox.Show("card clicked");
                };
                flowLayout.Controls.Add(productCard);

            }
        }

       
        

        
    }
}
