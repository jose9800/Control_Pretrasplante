using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;


namespace Capa_Negocio
{
    public class UsuarioLogin
    {
        DatosUsuario usuari1 = new DatosUsuario();

        public bool LoginUsuario(string usuario, string pass)
        {
            return usuari1.Logi_Us(usuario, pass);
        }
    }
}
