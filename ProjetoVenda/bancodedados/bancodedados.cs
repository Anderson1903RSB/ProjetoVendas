using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.database
{
    internal static class bancodedados
    {
        private static string textoDeConexao;

        static bancodedados()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""
            };
            textoDeConexao = builder.ConnectionString;
        }

        public static MySqlConnection conexao ()
        {
            MySqlConnection connection = new MySqlConnection (textoDeConexao);
            try
            {
                //
                connection.Open();
                return connection;
            }catch (MySqlException ex)
            {
                connection.Dispose();
                throw;
                //
            }
        }
    }
}
