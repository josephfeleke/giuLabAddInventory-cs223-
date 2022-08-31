using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace giuLabAddInventory
{
    public class Product
    {
        public string name { get; set; }
        public string itemName { get; set; }
        public int count { get; set; }
        public int inventoryNumber { get; set; }
        public DateTime date { get; set; }
        public int price { get; set; }

        public bool isAvailable { get; set; }

        public static List<Product> products = new List<Product>();


        public void save()
        {
            products.Add(this);
            string connectionString = @"Data Source= DESKTOP-U0V0OOO\MSSQLSERVER01; Initial Catalog = DB; Integrated Security = true;";
            SqlConnection co = new SqlConnection(connectionString);
            co.Open();
            string InsertProductQuery = $"insert into products values ('{this.name}','{this.itemName}','{this.inventoryNumber},'{this.price},'{this.date},'{this.count}')";
            SqlCommand com = new SqlCommand(InsertProductQuery, co);
            var result = com.ExecuteNonQuery();
            co.Close();
        } 


        public static List<Product> getAllProducts()
        {

            List<Product> tempProducts = new List<Product>();
            string connectionString = @"Data Source= DESKTOP-U0V0OOO\MSSQLSERVER01; Initial Catalog = DB; Integrated Security = true;";
            SqlConnection co = new SqlConnection(connectionString);
            co.Open();
            string selectProductsQuery = "select * from products";
            SqlCommand com = new SqlCommand(selectProductsQuery, co);
            var result = com.ExecuteReader();
            co.Close();

            while (result.Read())
            {
                tempProducts.Add(new Product { 
                    name = result["productName"].ToString(), 
                    itemName = result["itemName"].ToString(),
                    count = Int32.Parse(result["count"].ToString()),
                    inventoryNumber = Int32.Parse(result["inventoryNumber"].ToString()),
                    date = DateTime.Parse(result["date"].ToString()),
                    price = Int32.Parse(result["price"].ToString()),
                });  

            }

            return tempProducts;
        }

    }
}
