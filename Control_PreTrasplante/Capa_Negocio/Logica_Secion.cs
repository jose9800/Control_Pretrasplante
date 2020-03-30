using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;

namespace Capa_Negocio
{
    public class Logica_Secion
    {
        public Logica_Secion()
        {

        }

        Acceso_Datos Acceso_Datos = new Acceso_Datos();

        public bool Login_Usuario(string user, string pass)
        {
            return Acceso_Datos.Logi_Us(user,pass);
        }

        //public Boolean Consulta_Usuario(string usuario, string contraseña)
        //{
        //    //Buscar si existe el nombre de usuario
        //    int fila_usuario = 0;
        //    if (Capa_AccesoDatos.Acceso_Datos.Existe_Usuario(usuario, ref fila_usuario))
        //    {
        //        if (Capa_AccesoDatos.Acceso_Datos.Busca_Contr(contraseña, fila_usuario))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
