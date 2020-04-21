using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Capa_AccesoDatos
{
    public class Acceso_Datos:AD_ConexionMySQL
    {
        public bool Logi_Us(string usuario, string pass)
        {
            using (var connection = GetMySqlConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where Usuario=@user and Password=@pass;";
                    command.Parameters.AddWithValue("@user", usuario);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)//Obtiene un valor que especifica si existe
                    {
                        return true;//Si existe retorna true
                    }
                    else
                    {
                        return false;//Si no existe retorna false
                    }
                }
            }
        }

        private AD_ConexionMySQL conexion = new AD_ConexionMySQL();
        MySqlDataReader leerdatos;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarDatos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *from Paciente";
            //comando.CommandType = CommandType.StoredProcedure;
            leerdatos = comando.ExecuteReader();
            tabla.Load(leerdatos);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
