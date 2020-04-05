namespace Capa_Presentacion
{
    partial class Paciente
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
            this.lbl_apellidoP = new System.Windows.Forms.Label();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.txt_apellidoM = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.lbl_apellidoM = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.lbl_fechaNa = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.tbc_datosGenerales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.rdb_femenino = new System.Windows.Forms.RadioButton();
            this.ibtn_enviar = new FontAwesome.Sharp.IconButton();
            this.tbc_datosGenerales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Location = new System.Drawing.Point(5, 31);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(83, 13);
            this.lbl_apellidoP.TabIndex = 0;
            this.lbl_apellidoP.Text = "Apellido paterno";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Location = new System.Drawing.Point(97, 24);
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoP.TabIndex = 1;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Location = new System.Drawing.Point(97, 50);
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoM.TabIndex = 2;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(97, 77);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(100, 20);
            this.txt_nombres.TabIndex = 3;
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(355, 50);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(149, 20);
            this.txt_curp.TabIndex = 5;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(355, 24);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(96, 20);
            this.txt_rfc.TabIndex = 6;
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Location = new System.Drawing.Point(6, 57);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(85, 13);
            this.lbl_apellidoM.TabIndex = 9;
            this.lbl_apellidoM.Text = "Apellido materno";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(6, 84);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(58, 13);
            this.lbl_nombres.TabIndex = 10;
            this.lbl_nombres.Text = "Nombre (s)";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(243, 31);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(28, 13);
            this.lbl_rfc.TabIndex = 11;
            this.lbl_rfc.Text = "RFC";
            // 
            // lbl_curp
            // 
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Location = new System.Drawing.Point(243, 57);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(37, 13);
            this.lbl_curp.TabIndex = 12;
            this.lbl_curp.Text = "CURP";
            // 
            // lbl_fechaNa
            // 
            this.lbl_fechaNa.AutoSize = true;
            this.lbl_fechaNa.Location = new System.Drawing.Point(243, 84);
            this.lbl_fechaNa.Name = "lbl_fechaNa";
            this.lbl_fechaNa.Size = new System.Drawing.Size(106, 13);
            this.lbl_fechaNa.TabIndex = 13;
            this.lbl_fechaNa.Text = "Fecha de nacimiento";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(554, 31);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 14;
            this.lbl_sexo.Text = "Sexo";
            // 
            // tbc_datosGenerales
            // 
            this.tbc_datosGenerales.Controls.Add(this.tabPage1);
            this.tbc_datosGenerales.Controls.Add(this.tabPage2);
            this.tbc_datosGenerales.Location = new System.Drawing.Point(12, 12);
            this.tbc_datosGenerales.Name = "tbc_datosGenerales";
            this.tbc_datosGenerales.SelectedIndex = 0;
            this.tbc_datosGenerales.Size = new System.Drawing.Size(1205, 721);
            this.tbc_datosGenerales.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ibtn_enviar);
            this.tabPage1.Controls.Add(this.rdb_femenino);
            this.tabPage1.Controls.Add(this.rdb_masculino);
            this.tabPage1.Controls.Add(this.txt_apellidoP);
            this.tabPage1.Controls.Add(this.lbl_sexo);
            this.tabPage1.Controls.Add(this.txt_apellidoM);
            this.tabPage1.Controls.Add(this.lbl_fechaNa);
            this.tabPage1.Controls.Add(this.txt_nombres);
            this.tabPage1.Controls.Add(this.lbl_curp);
            this.tabPage1.Controls.Add(this.lbl_rfc);
            this.tabPage1.Controls.Add(this.txt_curp);
            this.tabPage1.Controls.Add(this.lbl_nombres);
            this.tabPage1.Controls.Add(this.lbl_apellidoM);
            this.tabPage1.Controls.Add(this.txt_rfc);
            this.tabPage1.Controls.Add(this.lbl_apellidoP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos especificos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Location = new System.Drawing.Point(603, 24);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_masculino.TabIndex = 15;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.Location = new System.Drawing.Point(603, 47);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(71, 17);
            this.rdb_femenino.TabIndex = 16;
            this.rdb_femenino.TabStop = true;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            // 
            // ibtn_enviar
            // 
            this.ibtn_enviar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtn_enviar.IconColor = System.Drawing.Color.Black;
            this.ibtn_enviar.IconSize = 16;
            this.ibtn_enviar.Location = new System.Drawing.Point(599, 108);
            this.ibtn_enviar.Name = "ibtn_enviar";
            this.ibtn_enviar.Rotation = 0D;
            this.ibtn_enviar.Size = new System.Drawing.Size(75, 23);
            this.ibtn_enviar.TabIndex = 17;
            this.ibtn_enviar.Text = "enviar";
            this.ibtn_enviar.UseVisualStyleBackColor = true;
            this.ibtn_enviar.Click += new System.EventHandler(this.ibtn_enviar_Click);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1229, 761);
            this.Controls.Add(this.tbc_datosGenerales);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.tbc_datosGenerales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.TextBox txt_apellidoM;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label lbl_apellidoM;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.Label lbl_fechaNa;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TabControl tbc_datosGenerales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rdb_femenino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton ibtn_enviar;
    }
}