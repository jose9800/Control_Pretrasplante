using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Estudios : Form
    {
        string[] datos;
        public Estudios()
        {
            InitializeComponent();
        }

        public Estudios(string [] datos)
        {
            InitializeComponent();
            this.datos = new string[datos.Length];
            this.datos = datos;
        }
        private void Estudios_Load(object sender, EventArgs e)
        {
            nombre.Text = datos[3];
            AP.Text = datos[4];
            AM.Text = datos[5];
            curp.Text = datos[2];
            NSS.Text = datos[1];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
