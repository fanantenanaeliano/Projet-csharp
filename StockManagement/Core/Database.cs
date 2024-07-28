using System;
using Npgsql;

namespace WpfApp2.Models
{
    class Database
    {
        private static string settings = "Server=localhost;Database=csharp_db;Username=postgres;Password=passe";
        public static NpgsqlConnection connect()
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(settings);
                connection.Open();

                return connection;
            }
            catch(PostgresException err)
            {
                Console.WriteLine($"Erreur connexion a la base de donne : {err.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
