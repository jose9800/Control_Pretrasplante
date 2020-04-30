namespace Capa_Presentacion.Formularios
{
    partial class Lista_Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fotopaciente = new System.Windows.Forms.PictureBox();
            this.N_paciente = new System.Windows.Forms.Label();
            this.N_seguro = new System.Windows.Forms.Label();
            this.Edad_Paciente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.E_realizados = new System.Windows.Forms.Label();
            this.E_pendientes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fotopaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // fotopaciente
            // 
            this.fotopaciente.Location = new System.Drawing.Point(12, 12);
            this.fotopaciente.Name = "fotopaciente";
            this.fotopaciente.Size = new System.Drawing.Size(127, 140);
            this.fotopaciente.TabIndex = 0;
            this.fotopaciente.TabStop = false;
            // 
            // N_paciente
            // 
            this.N_paciente.AutoSize = true;
            this.N_paciente.Location = new System.Drawing.Point(164, 34);
            this.N_paciente.Name = "N_paciente";
            this.N_paciente.Size = new System.Drawing.Size(117, 17);
            this.N_paciente.TabIndex = 1;
            this.N_paciente.Text = "Nombre Paciente";
            // 
            // N_seguro
            // 
            this.N_seguro.AutoSize = true;
            this.N_seguro.Location = new System.Drawing.Point(164, 61);
            this.N_seguro.Name = "N_seguro";
            this.N_seguro.Size = new System.Drawing.Size(170, 17);
            this.N_seguro.TabIndex = 2;
            this.N_seguro.Text = "Numero de Seguro Social";
            // 
            // Edad_Paciente
            // 
            this.Edad_Paciente.AutoSize = true;
            this.Edad_Paciente.Location = new System.Drawing.Point(164, 88);
            this.Edad_Paciente.Name = "Edad_Paciente";
            this.Edad_Paciente.Size = new System.Drawing.Size(41, 17);
            this.Edad_Paciente.TabIndex = 3;
            this.Edad_Paciente.Text = "Edad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 1);
            this.panel1.TabIndex = 4;
            // 
            // E_realizados
            // 
            this.E_realizados.AutoSize = true;
            this.E_realizados.Location = new System.Drawing.Point(12, 179);
            this.E_realizados.Name = "E_realizados";
            this.E_realizados.Size = new System.Drawing.Size(136, 17);
            this.E_realizados.TabIndex = 5;
            this.E_realizados.Text = "Estudios Realizados";
            // 
            // E_pendientes
            // 
            this.E_pendientes.AutoSize = true;
            this.E_pendientes.Location = new System.Drawing.Point(12, 269);
            this.E_pendientes.Name = "E_pendientes";
            this.E_pendientes.Size = new System.Drawing.Size(137, 17);
            this.E_pendientes.TabIndex = 7;
            this.E_pendientes.Text = "Estudios Pendientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(15, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 1);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nuevo Estudio";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(15, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 1);
            this.panel3.TabIndex = 8;
            // 
            // Lista_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.E_pendientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.E_realizados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edad_Paciente);
            this.Controls.Add(this.N_seguro);
            this.Controls.Add(this.N_paciente);
            this.Controls.Add(this.fotopaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Pacientes";
            this.Text = "Lista_Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.fotopaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotopaciente;
        private System.Windows.Forms.Label N_paciente;
        private System.Windows.Forms.Label N_seguro;
        private System.Windows.Forms.Label Edad_Paciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label E_realizados;
        private System.Windows.Forms.Label E_pendientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}