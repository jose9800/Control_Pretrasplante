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
        

        //static string[,] usuarios;//Supuesta base de datos
        //static public void  Insertar()
        //{
        //    usuarios = new string[10, 2];//Registros de la supesta base de datos
        //    usuarios[0, 0] = "Abraham";
        //    usuarios[0, 1] = "1234";
        //    usuarios[1, 0] = "Jose";
        //    usuarios[1, 1] = "1234";
        //}

        //static public Boolean Existe_Usuario(string cadena, ref int fila)
        //{
        //    Insertar();
        //    //Simular busqueda en base de datos
        //    for(int x = 0; x < usuarios.Length; x++)
        //    {
        //        if(cadena == usuarios[x, 0])
        //        {
        //            fila = x;
        //            return true;
        //        }
        //        else { }
        //    }
        //    return false;
        //}

        //static public Boolean Busca_Contr(string cadena, int fila)
        //{
        //    //Simular busqueda en base de datos
        //    if (cadena == usuarios[fila, 1])
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
