using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar las librerias correspondientes
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;

namespace Capa_Presentacion
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void ibtn_enviar_Click(object sender, EventArgs e)
        {
            //initialize word object  
            Document document = new Document();
            document.LoadFromFile(@"C:\Users\moran\Downloads\Formulario-de-atención-PreHospitalaria.docx");
            //get strings to replace  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }
            //Save doc file.  
            document.SaveToFile("Formulario1.docx", FileFormat.Docx);
            //Convert to PDF  
            document.SaveToFile("Formulario1.pdf", FileFormat.PDF);
            MessageBox.Show("All tasks are finished.", "doc processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();

            Dictionary<string, string> GetReplaceDictionary()
            {
                Dictionary<string, string> replaceDict = new Dictionary<string, string>();
                replaceDict.Add("#apellidoP#", txt_apellidoP.Text.Trim());
                replaceDict.Add("#apellidoM#", txt_apellidoM.Text);
                replaceDict.Add("#nombre#", txt_nombres.Text.Trim());
                
                return replaceDict;
            }
        }
    }
}
