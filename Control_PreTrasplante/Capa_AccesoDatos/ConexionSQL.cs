using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias sqlserver
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class ConexionSQL
    {
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-0OJ1B95\SQLEXPRESS;Initial Catalog=Pacientespretrasplante;Integrated Security=True");
        }
        private SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-0OJ1B95\SQLEXPRESS;Initial Catalog=Pacientespretrasplante;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
