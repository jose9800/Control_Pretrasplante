using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Formularios
{
    public partial class Lista_P : Form
    {
        Panel from;
        public Lista_P(Panel inicio)
        {
            InitializeComponent();
            from = inicio;
        }

        private void MostrarPa()//Método para vizualizar los registros de la DB
        {
            Capa_Negocio.CN_Paciente objforma = new Capa_Negocio.CN_Paciente();
            Lista.DataSource = objforma.MostrarPaci();
        }

        private void Lista_P_Load(object sender, EventArgs e)
        {
            MostrarPa();
        }

        private void Lista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            from.Controls.RemoveAt(0);
            Estudios p = new Estudios();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            from.Controls.Add(p);
            from.Tag = p;
            p.Show();
        }
    }
}
