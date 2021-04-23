using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFact
{
    public partial class frmABMpersonas : Form
    {
        Acceso A = new Acceso();
        public frmABMpersonas()
        {
            InitializeComponent();
        }

        private void frmABMpersonas_Load(object sender, EventArgs e)
        {
            Carga_combo();
        }
        private void Carga_combo() {
            A.Consulta("Select 0 c_tipo_documento ,'<Seleccione>' x_sigla UNION select c_tipo_documento, x_sigla  from BTIPO_DOCUMENTO", "R");
            cboDoc.DataSource = A.ds.Tables["R"];
            cboDoc.ValueMember = "c_tipo_documento";
            cboDoc.DisplayMember = "x_sigla";
            A.conexion.Close();

            cboSexo.Items.Add("<Seleccione>");
            cboSexo.Items.Add("F");
            cboSexo.Items.Add("M");

            A.Consulta("Select 0 c_pais, '<Seleccione>' x_pais UNION Select * from bpais", "R");
            cboPais.DataSource = A.ds.Tables["R"];
            cboPais.ValueMember = "c_pais";
            cboPais.ValueMember = "x_pais";
            A.conexion.Close();
        }
    }
}
