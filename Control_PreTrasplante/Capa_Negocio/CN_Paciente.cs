using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias
using System.Data;
using System.Data.SqlClient;
using Capa_AccesoDatos;

namespace Capa_Negocio
{
   public class CN_Paciente
    {
        private Acceso_Datos objPaciente = new Acceso_Datos();
        public DataTable MostrarPaci()
        {
            DataTable tabla = new DataTable();
            tabla = objPaciente.MostrarDatos();
            return tabla;
        }
    }
}
