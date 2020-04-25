using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar libreria 
using FontAwesome.Sharp;

namespace Capa_Presentacion
{
    public partial class Inicio : Form
    {
        //Variables globales

        private IconButton botonicono;
        private Panel panel_izqiuerdo;
        private Form formularioHijo;

        //Constructor
        public Inicio()
        {
            InitializeComponent();
            panel_izqiuerdo = new Panel();
            panel_izqiuerdo.Size = new Size(7, 50);
        }
        private void BotonActivado(object enviarboton, Color color)
        {
            if (enviarboton != null)
            {
                BotonDesactivado();
                //boton
                botonicono = (IconButton)enviarboton;
                botonicono.BackColor = Color.White;
                botonicono.ForeColor = color;
                botonicono.TextAlign = ContentAlignment.MiddleCenter;
                botonicono.IconColor = color;
                botonicono.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonicono.ImageAlign = ContentAlignment.MiddleRight;
                //borde lateral del boton
                panel_izqiuerdo.BackColor = color;
                panel_izqiuerdo.Location = new Point(0, botonicono.Location.Y);
                panel_izqiuerdo.Visible = true;
                panel_izqiuerdo.BringToFront();
            }
        }
        private void BotonDesactivado()
        {
            if (botonicono != null)
            {
                //boton
                botonicono.BackColor = Color.FromArgb(30, 142, 160);
                botonicono.ForeColor = Color.Black;
                botonicono.TextAlign = ContentAlignment.MiddleCenter;
                botonicono.IconColor = Color.Black;
                botonicono.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonicono.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        //Abrir formulario
        private void AbrirFormularios(Form hijo)
        {
            if (formularioHijo != null)
            {
                //abrir solo un formulario
                formularioHijo.Close();
            }
            formularioHijo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panel_central.Controls.Add(hijo);
            hijo.BringToFront();
            hijo.Show();
        }
        //Código para botones
        private void iconbtn_inicio_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularios(new Inicio_central());
        }

        private void iconbtn_reportes_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularios(new Reportes());
        }

        private void iconbtn_estudios_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularios(new Estudios());
        }

        private void iconbtn_paciente_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularios(new Paciente());
            
        }
    }
}
