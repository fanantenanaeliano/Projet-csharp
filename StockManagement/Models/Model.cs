using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Npgsql;

namespace WpfApp2.Models
{
    class Model
    {
        protected static NpgsqlConnection connection = Database.connect();

        public void viderContenuChamp(List<TextBox> champtext)
        {

        }

    }
}
