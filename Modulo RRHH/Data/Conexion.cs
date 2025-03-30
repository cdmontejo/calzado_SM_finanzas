using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ModuloRRHH.Data
{
    public class Conexion
    {
        private string connectionString = "server=localhost; database=calzado_san_miguel; user=root; password=;";


        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}