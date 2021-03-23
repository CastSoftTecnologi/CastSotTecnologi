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
    public partial class frmABMProductos : Form
    {
        Acceso A = new Acceso();
        public frmABMProductos()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void frmABMProductos_Load(object sender, EventArgs e)
        {
            Carga_Combos();
        }
        private void Carga_Combos() {
            A.Consulta("Select 0 Codigo, '<Seleccione>' Des UNION Select cCategoria, x_categoria from BCategoria", "R");
            cboCategoria.DataSource = A.ds.Tables["R"];
            cboCategoria.DisplayMember = "Des";
            cboCategoria.ValueMember = "Codigo";
            A.conexion.Close();

            A.Consulta("Select 0 Codigo, '<Seleccione>' Des UNION Select cUnidad, x_Unidad from BUnidad", "R");
            cboUnidad.DataSource = A.ds.Tables["R"];
            cboUnidad.DisplayMember = "Des";
            cboUnidad.ValueMember = "Codigo";
            A.conexion.Close();

            A.Consulta("Select 0 Codigo, '<Seleccione>' Des UNION Select cIVA, replace(left(cast(nIva as varchar(10)),5),'.',',') as Des from BIVA", "R");
            cboIVA.DataSource = A.ds.Tables["R"];
            cboIVA.DisplayMember = "Des";
            cboIVA.ValueMember = "Codigo";
            A.conexion.Close();

        }

    }
}
