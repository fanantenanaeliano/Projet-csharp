using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Entities;

namespace WpfApp2.Models
{
    internal class OperationModel : Model
    {
        public void add(Operation op)
        {
            try
            {
                string query = "INSERT INTO operation(product_reference, product_name, product_amount, product_price) VALUES(@product_reference, @product_name, @product_amount, @product_price)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    //cmd.Parameters.AddWithValue("@product_reference", p.reference);
                    //cmd.Parameters.AddWithValue("@product_name", p.name);
                    //cmd.Parameters.AddWithValue("@product_amount", p.amount);
                    //cmd.Parameters.AddWithValue("@product_price", p.price);

                    if (cmd.ExecuteNonQuery() != -1)
                        MessageBox.Show("Entrée enregistré");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
