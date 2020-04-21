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
            this.btn_foto = new System.Windows.Forms.Button();
            this.gbx_Registro = new System.Windows.Forms.GroupBox();
            this.lbl_Estudios = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ibtn_enviar = new FontAwesome.Sharp.IconButton();
            this.rdb_femenino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.ptb_Foto = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbc_datosGenerales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbx_Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.Location = new System.Drawing.Point(28, 121);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(124, 20);
            this.lbl_apellidoP.TabIndex = 0;
            this.lbl_apellidoP.Text = "Apellido paterno";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Location = new System.Drawing.Point(177, 115);
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(189, 26);
            this.txt_apellidoP.TabIndex = 1;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Location = new System.Drawing.Point(177, 155);
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(189, 26);
            this.txt_apellidoM.TabIndex = 2;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(177, 75);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(189, 26);
            this.txt_nombres.TabIndex = 3;
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(177, 235);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(221, 26);
            this.txt_curp.TabIndex = 5;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(177, 195);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(221, 26);
            this.txt_rfc.TabIndex = 6;
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoM.Location = new System.Drawing.Point(28, 161);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(128, 20);
            this.lbl_apellidoM.TabIndex = 9;
            this.lbl_apellidoM.Text = "Apellido materno";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.Location = new System.Drawing.Point(28, 81);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(87, 20);
            this.lbl_nombres.TabIndex = 10;
            this.lbl_nombres.Text = "Nombre (s)";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfc.Location = new System.Drawing.Point(28, 201);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(122, 20);
            this.lbl_rfc.TabIndex = 11;
            this.lbl_rfc.Text = "Num.Seg.Social";
            // 
            // lbl_curp
            // 
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.Location = new System.Drawing.Point(28, 241);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(54, 20);
            this.lbl_curp.TabIndex = 12;
            this.lbl_curp.Text = "CURP";
            // 
            // lbl_fechaNa
            // 
            this.lbl_fechaNa.AutoSize = true;
            this.lbl_fechaNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaNa.Location = new System.Drawing.Point(489, 75);
            this.lbl_fechaNa.Name = "lbl_fechaNa";
            this.lbl_fechaNa.Size = new System.Drawing.Size(157, 20);
            this.lbl_fechaNa.TabIndex = 13;
            this.lbl_fechaNa.Text = "Fecha de nacimiento";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(34, 304);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(45, 20);
            this.lbl_sexo.TabIndex = 14;
            this.lbl_sexo.Text = "Sexo";
            // 
            // tbc_datosGenerales
            // 
            this.tbc_datosGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_datosGenerales.Controls.Add(this.tabPage1);
            this.tbc_datosGenerales.Controls.Add(this.tabPage2);
            this.tbc_datosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_datosGenerales.Location = new System.Drawing.Point(12, 12);
            this.tbc_datosGenerales.Name = "tbc_datosGenerales";
            this.tbc_datosGenerales.SelectedIndex = 0;
            this.tbc_datosGenerales.Size = new System.Drawing.Size(1205, 721);
            this.tbc_datosGenerales.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_foto);
            this.tabPage1.Controls.Add(this.gbx_Registro);
            this.tabPage1.Controls.Add(this.ptb_Foto);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(254, 189);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(140, 30);
            this.btn_foto.TabIndex = 23;
            this.btn_foto.Text = "Agregar foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            // 
            // gbx_Registro
            // 
            this.gbx_Registro.Controls.Add(this.txt_nombres);
            this.gbx_Registro.Controls.Add(this.lbl_Estudios);
            this.gbx_Registro.Controls.Add(this.lbl_apellidoP);
            this.gbx_Registro.Controls.Add(this.comboBox1);
            this.gbx_Registro.Controls.Add(this.txt_rfc);
            this.gbx_Registro.Controls.Add(this.monthCalendar1);
            this.gbx_Registro.Controls.Add(this.lbl_apellidoM);
            this.gbx_Registro.Controls.Add(this.lbl_nombres);
            this.gbx_Registro.Controls.Add(this.ibtn_enviar);
            this.gbx_Registro.Controls.Add(this.txt_curp);
            this.gbx_Registro.Controls.Add(this.rdb_femenino);
            this.gbx_Registro.Controls.Add(this.lbl_rfc);
            this.gbx_Registro.Controls.Add(this.rdb_masculino);
            this.gbx_Registro.Controls.Add(this.lbl_curp);
            this.gbx_Registro.Controls.Add(this.txt_apellidoP);
            this.gbx_Registro.Controls.Add(this.lbl_fechaNa);
            this.gbx_Registro.Controls.Add(this.lbl_sexo);
            this.gbx_Registro.Controls.Add(this.txt_apellidoM);
            this.gbx_Registro.Location = new System.Drawing.Point(55, 225);
            this.gbx_Registro.Name = "gbx_Registro";
            this.gbx_Registro.Size = new System.Drawing.Size(1108, 382);
            this.gbx_Registro.TabIndex = 22;
            this.gbx_Registro.TabStop = false;
            this.gbx_Registro.Text = "Registro de paciente";
            // 
            // lbl_Estudios
            // 
            this.lbl_Estudios.AutoSize = true;
            this.lbl_Estudios.Location = new System.Drawing.Point(812, 75);
            this.lbl_Estudios.Name = "lbl_Estudios";
            this.lbl_Estudios.Size = new System.Drawing.Size(134, 20);
            this.lbl_Estudios.TabIndex = 21;
            this.lbl_Estudios.Text = "Estudios médicos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Banco de sangre",
            "Programación de cirugia",
            "Orden de internamiento",
            "Interconsultas",
            "Estudios de laboratorio",
            "Estudios de medicina nuclear"});
            this.comboBox1.Location = new System.Drawing.Point(816, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(493, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // ibtn_enviar
            // 
            this.ibtn_enviar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtn_enviar.IconColor = System.Drawing.Color.Black;
            this.ibtn_enviar.IconSize = 16;
            this.ibtn_enviar.Location = new System.Drawing.Point(853, 320);
            this.ibtn_enviar.Name = "ibtn_enviar";
            this.ibtn_enviar.Rotation = 0D;
            this.ibtn_enviar.Size = new System.Drawing.Size(117, 31);
            this.ibtn_enviar.TabIndex = 17;
            this.ibtn_enviar.Text = "Registrar";
            this.ibtn_enviar.UseVisualStyleBackColor = true;
            this.ibtn_enviar.Click += new System.EventHandler(this.ibtn_enviar_Click);
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.Location = new System.Drawing.Point(83, 320);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(98, 24);
            this.rdb_femenino.TabIndex = 16;
            this.rdb_femenino.TabStop = true;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Location = new System.Drawing.Point(83, 297);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(98, 24);
            this.rdb_masculino.TabIndex = 15;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // ptb_Foto
            // 
            this.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_Foto.Location = new System.Drawing.Point(55, 41);
            this.ptb_Foto.Name = "ptb_Foto";
            this.ptb_Foto.Size = new System.Drawing.Size(193, 178);
            this.ptb_Foto.TabIndex = 18;
            this.ptb_Foto.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1197, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes registrados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1191, 511);
            this.dataGridView1.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.tbc_datosGenerales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbx_Registro.ResumeLayout(false);
            this.gbx_Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private FontAwesome.Sharp.IconButton ibtn_enviar;
        private System.Windows.Forms.GroupBox gbx_Registro;
        private System.Windows.Forms.Label lbl_Estudios;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox ptb_Foto;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}