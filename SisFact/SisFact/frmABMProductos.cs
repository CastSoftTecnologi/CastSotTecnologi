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
            if (txtCodigo.Text != "") {

                A.Lectura("Select * from TProducto where cProducto = " + txtCodigo.Text );
                if (A.dr.Read()) {
                    txtNombre.Text = A.dr["xl_producto"].ToString();
                    txtNombreCorto.Text = A.dr["x_producto"].ToString();
                    txtPrecioU.Text = A.dr["i_precioUnitario"].ToString();
                    txtcBarra.Text = A.dr["cBarra"].ToString();
                    txtStockMin.Text = A.dr["nUnidadesMin"].ToString();
                    cboCategoria.SelectedValue  = A.dr["cCategoria"];
                    cboIVA.SelectedValue = A.dr["cIva"];
                    cboUnidad.SelectedValue = A.dr["cUnidaMedida"];
                    cboMarca.SelectedValue = A.dr["cMarca"];
                    chkVenta.Checked = bool.Parse(A.dr["m_venta"].ToString());
                    chkFormula.Checked = bool.Parse(A.dr["m_formula"].ToString());
                    chkActivo.Checked = bool.Parse(A.dr["m_activo"].ToString());
                    chkVisible.Checked = bool.Parse(A.dr["m_visible"].ToString());
                }
                A.conexion.Close();
            }
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

            A.Consulta("Select 0 Codigo, '<Seleccione>' Des UNION Select cMarca, x_marca Des from BMarca", "R");
            cboMarca.DataSource = A.ds.Tables["R"];
            cboMarca.DisplayMember = "Des";
            cboMarca.ValueMember = "Codigo";
            A.conexion.Close();
        }

        private void btnGuradar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") {
                MessageBox.Show("Debe Indicar el Nombre", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNombreCorto.Text == "") {
                MessageBox.Show("Debe Indicar el Nombre Corto", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chkVenta.Checked == true) {
                if (txtPrecioU.Text == "") {
                    MessageBox.Show("Debe Indicar el Precio Unitario", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(cboIVA.SelectedValue.ToString()) == 0) {
                    MessageBox.Show("Debe Indicar el IVA", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (int.Parse(cboCategoria.SelectedValue.ToString()) == 0) {
                return;
            }
            if (txtStockMin.Text == "")
            {
                MessageBox.Show("Debe Indicar el Stock Minimo", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtCodigo.Text == "") { 
            A.Ejecuta("exec INS_TPRODUCTO @xl_producto = '" + txtNombre.Text + "'" +
            ", @x_producto      = '" + txtNombreCorto.Text + "'" +
            ", @i_precioUnitario = " + txtPrecioU.Text +
            ", @cCategoria       = " + cboCategoria.SelectedValue.ToString() +
            ", @cUnidaMedida     = " + cboUnidad.SelectedValue.ToString() +
            ", @cMarca           = " + cboMarca.SelectedValue.ToString() +
            ", @c_usuario        = " + Acceso.c_usuario.ToString() +
            ", @m_activo         = " + (chkActivo.Checked == true?"1":"0") +
            ", @m_visible        = " + (chkVisible.Checked == true?"1":"0") +
            ", @m_venta          = " + (chkVenta.Checked  == true?"1":"0") +
            ", @m_formula        = " + (chkFormula.Checked == true ? "1" : "0") +
            ", @cBarra           = '" + txtcBarra.Text + "'" +
            ", @cIva             = " + cboIVA.SelectedValue.ToString() +
            ", @nUnidadesMin     = " + int.Parse(txtStockMin.Text));
            }
            MessageBox.Show("Datos Gargados","Aviso...",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmProductos FP = Owner as frmProductos;//Este permite actulizar la grilla haciendo que padre acepte la peticion de hijo
            FP.buscar_Registros();//esta funcion es de PAdre frmProductos pero la peticion de viene de frmABMProductos
            Dispose();
            Close();
        }

        private void txtPrecioU_TextChanged(object sender, EventArgs e)
        {
            if (A.IsNumeric(txtPrecioU.Text) == false) {
                txtPrecioU.Text = "";
            }
        }

        private void txtStockMin_TextChanged(object sender, EventArgs e)
        {
            if (A.IsNumeric(txtStockMin.Text) == false)
            {
                txtStockMin.Text = "";
            }
        }
    }
}
