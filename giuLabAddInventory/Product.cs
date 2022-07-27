using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giuLabAddInventory
{
    internal class Product
    {
        public string name { get; set; }
        public string itemName { get; set; }
        public int count { get; set; }
        public int inventoryNumber { get; set; }
        public DateTime date { get; set; }
        public int price { get; set; }

        static List<Product> products = new List<Product>();

      
        public void save()
        {
            products.Add(this);
        }

        public static List<Product> getAllProducts()
        {
            return products;
        }

    }
}
