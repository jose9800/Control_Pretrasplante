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

    }
}
