using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Formularios;
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
            PerzonalisarDiseño();
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
                //botonicono.BackColor = Color.FromArgb(30, 142, 160);
                botonicono.BackColor = Color.FromArgb(13, 102, 87);
                botonicono.ForeColor = Color.Black;
                botonicono.TextAlign = ContentAlignment.MiddleCenter;
                botonicono.IconColor = Color.Black;
                botonicono.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonicono.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        //Abrir formulario
        public void AbrirFormularios(Form hijo)
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
            OcultarSubmenu();
        }

        private void iconbtn_reportes_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularios(new Reportes());
            OcultarSubmenu();
        }

        private void iconbtn_estudios_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            AbrirFormularios(new Estudios());
            OcultarSubmenu();
        }

        private void iconbtn_paciente_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(253, 138, 114));
            MostrarSubmenu();
        }

        void PerzonalisarDiseño()
        {
            submenu_paciente.Visible = false;
        }

        void OcultarSubmenu(/*Panel submenu*/)
        {
            //if (submenu.Visible ==true)
            //{
            //    submenu_paciente.Visible = false;
            //}
            //else { }
            submenu_paciente.Visible = false;
        }

        void MostrarSubmenu(/*Panel submenu*/)
        {
            //if (submenu.Visible==false)
            //{
            //    //OcultarSubmenu();
            //    submenu_paciente.Visible = true;
            //}
            ////else { submenu.Visible = false; }
            submenu_paciente.Visible = true;
        }

        private void nuevo_paciente_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Paciente());
            //OcultarSubmenu();
        }

        private void lista_paciente_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Lista_P(panel_central));
            //OcultarSubmenu();
        }

        //---------------------------------------Botones para cerrar sesión, minimizar y cerrar aplicación-------------------------------------
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar sesión, ¿estas seguro?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btn_CerrarTodo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar aplicación, ¿estas seguro?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
