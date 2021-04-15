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
        int pestana;
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
            btnAgregar.Enabled = false;
            btnBuscar.Enabled = false;
            if (txtCodigo.Text != "") {
                Carga_Data(txtCodigo.Text);
            }
        }
        private void Carga_Data(string Cod) {
            A.Lectura("Select * from TProducto where cProducto = " + Cod);
            if (A.dr.Read())
            {
                txtNombre.Text = A.dr["xl_producto"].ToString();
                txtNombreCorto.Text = A.dr["x_producto"].ToString();
                txtPrecioU.Text = Math.Round(double.Parse(A.dr["i_precioUnitario"].ToString()), 2).ToString();
                txtcBarra.Text = A.dr["cBarra"].ToString();
                txtStockMin.Text = A.dr["nUnidadesMin"].ToString();
                txtNfactnum.Text = A.dr["nFactornumerico"].ToString();
                cboCategoria.SelectedValue = A.dr["cCategoria"];
                cboIVA.SelectedValue = A.dr["cIva"];
                cboUnidad.SelectedValue = A.dr["cUnidaMedida"];
                cboMarca.SelectedValue = A.dr["cMarca"];
                chkVenta.Checked = bool.Parse(A.dr["m_venta"].ToString());
                chkFormula.Checked = bool.Parse(A.dr["m_formula"].ToString());
                chkActivo.Checked = bool.Parse(A.dr["m_activo"].ToString());
                chkVisible.Checked = bool.Parse(A.dr["m_visible"].ToString());
            }
            A.conexion.Close();

            A.Lectura("Select * from V_Formula_Productos where cProducto = " + txtCodigo.Text);
            while (A.dr.Read() == true) {
                FProducto.Rows.Add(A.dr["codigo"].ToString(),A.dr["Descripcion"].ToString(),A.dr["Cantidad"].ToString());
            }
            A.conexion.Close();
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
            string sSql = "";
            string codprod = "";
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
                MessageBox.Show("Debe Indicar la categoria", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtStockMin.Text == "")
            {
                MessageBox.Show("Debe Indicar el Stock Minimo", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNfactnum.Text == "") {
                txtNfactnum.Text = "1";
            }


            if (txtPrecioU.Text == "") {
                txtPrecioU.Text = "0";
            }

            if (chkFormula.Checked == true && FProducto.Rows.Count == 0) {
                MessageBox.Show("Debe Indicar la composicion de la Formula", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtCodigo.Text == "")
            {
                sSql = "exec INS_TPRODUCTO ";
            }
            else
            {
                sSql = "exec UPD_TPRODUCTO @cProducto = " + txtCodigo.Text + ",";
            }


            A.Lectura(sSql + 
            "  @xl_producto     = '" + txtNombre.Text + "'" +
            ", @x_producto      = '" + txtNombreCorto.Text + "'" +
            ", @i_precioUnitario = " + txtPrecioU.Text.Replace(".","").Replace(",",".") +
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
            ", @nUnidadesMin     = " + int.Parse(txtStockMin.Text) +
            ", @nFactornumerico  = " + int.Parse(txtNfactnum.Text));
            if (A.dr.Read()) {
                if (A.dr[0].ToString() != "1") {
                    return;
                }
                codprod = A.dr["Codigo"].ToString();
            }
            A.conexion.Close();
            A.Ejecuta("Delete from TPRODUCTO_FORMULA where cProducto = " + codprod);

            foreach (DataGridViewRow Fila in FProducto.Rows)
            {
                A.Ejecuta("exec INS_TPRODUCTO_FORMULA " +
                          " @cProducto = " + codprod +
                          ",@cProducto_Insumo = " + Fila.Cells["Codigo"].Value.ToString() +
                          ",@Cantidad = " + Fila.Cells["Cantidad"].Value.ToString());
            }
            
            MessageBox.Show("Datos Gargados","Aviso...",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmProductos FP = Owner as frmProductos;//Este permite actulizar la grilla haciendo que padre acepte la peticion de hijo
            FP.buscar_Registros();//esta funcion es de Padre frmProductos pero la peticion de viene de frmABMProductos
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

        private void txtNfactnum_TextChanged(object sender, EventArgs e)
        {
            if (A.IsNumeric(txtNfactnum.Text) == false)
            {
                txtNfactnum.Text = "";
            }
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            if (A.IsNumeric(txtCant.Text) == false)
            {
                txtCant.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            browserProductosNoVentas FP = new browserProductosNoVentas();
            AddOwnedForm(FP);
            FP.TopLevel = false;
            FP.Dock = DockStyle.Fill;
            this.Controls.Add(FP);
            this.Tag = FP;
            FP.BringToFront();
            FP.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "" && txtCant.Text != "") {
                foreach (DataGridViewRow fila in FProducto.Rows)
                {
                    if (fila.Cells["Codigo"].Value.ToString() == txtCod.Text) {
                        MessageBox.Show("Ya se agrego este insumo " + txtDesc.Text , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                FProducto.Rows.Add(txtCod.Text, txtDesc.Text, txtCant.Text);
                txtCod.Text = "";
                txtDesc.Text = "";
                txtCant.Text = "";
            }
        }

        private void chkFormula_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFormula.Checked == true) {
                btnAgregar.Enabled = true;
                btnBuscar.Enabled = true; 
            }
        }
    }
}
