using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        Logica_Secion secion;
        public Login()
        {
            InitializeComponent();
        }

        //private void btn_Entrar_Click(object sender, EventArgs e)
        //{
        //    if(secion.Login_Usuario(Nombre_U.Text, Contraseña.Text))
        //    {
        //        MessageBox.Show("Iniciaste secion");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nel prro");
        //    }
        //}

        private void Login_Load(object sender, EventArgs e)
        {
            secion = new Logica_Secion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mostrarform = new Inicio();
            mostrarform.Show();
        }
    }
}
