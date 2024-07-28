using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;
using WpfApp2.Entities;

namespace WpfApp2.Models
{
    class ProductModel: Model
    {
        public static List<Product> getAll()
        {
            try
            {
                string query = "SELECT * FROM product";

                using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    using(NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        List<Product> productList = new List<Product>(4);

                        while(dr.Read())
                        {
                            productList.Add(new Product(dr.GetString(0), dr.GetString(1), dr.GetInt32(2), dr.GetInt32(3)));
                        }

                        return productList;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return null;
        }

        public static void add(Product p)
        {
            try
            {
                string query = "INSERT INTO product(product_reference, product_name, product_amount, product_price) VALUES(@product_reference, @product_name, @product_amount, @product_price)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@product_reference", p.reference);
                    cmd.Parameters.AddWithValue("@product_name", p.name);
                    cmd.Parameters.AddWithValue("@product_amount", p.amount);
                    cmd.Parameters.AddWithValue("@product_price", p.price);

                    if (cmd.ExecuteNonQuery() != -1)
                        MessageBox.Show("Produit ajouté");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
