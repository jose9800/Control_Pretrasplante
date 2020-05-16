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
        string[] datos;
        Estudios estudios;
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
            datos = new string[7];
            estudios = null;
        }

        private void Lista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*from.Controls.RemoveAt(0);
            Estudios p = new Estudios();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            from.Controls.Add(p);
            from.Tag = p;
            p.Show();*/
        }

        private void Lista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            datos[0] = Lista.Rows[e.RowIndex].Cells[0].Value.ToString();
            datos[1] = Lista.Rows[e.RowIndex].Cells[1].Value.ToString();
            datos[2] = Lista.Rows[e.RowIndex].Cells[2].Value.ToString();
            datos[3] = Lista.Rows[e.RowIndex].Cells[3].Value.ToString();
            datos[4] = Lista.Rows[e.RowIndex].Cells[4].Value.ToString();
            datos[5] = Lista.Rows[e.RowIndex].Cells[5].Value.ToString();
            datos[6] = Lista.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (estudios != null)
            {
                estudios.Close();
                estudios = null;
            }
            else
            {

            }
            estudios = new Estudios(datos);
            estudios.TopMost = true;
            estudios.Visible = true;
        }
    }
}
