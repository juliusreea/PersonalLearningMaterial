using Dapper;
using System;
using System.Data.SqlClient;

namespace DapperPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sql = "SELECT * FROM Drinks;";
            string connString = $"Server=localhost;Database=Goods;Trusted_Connection=True;";

            using var connection = new SqlConnection(connString);
            connection.Open();
            var data = connection.Query<Drinks>(sql);
        }
    }
}
