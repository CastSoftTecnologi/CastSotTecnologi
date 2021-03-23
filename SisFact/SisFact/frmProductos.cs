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
    public partial class frmProductos : Form
    {
        Acceso A = new Acceso();
        string Campo;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Diseno_grilla();
            buscar_Registros();
           
        }

        private void Diseno_grilla() {
            // esto pasa también cuando toco la cabezera de la columna  --- solo aqui queda por difault la primera columna
            lbbusqueda.Text = LProductos.Columns[0].HeaderText;//aqui indico al usuario por cual campo estoy filtrando
            Campo = LProductos.Columns[0].Name.ToString();//aqui indico a la variable campo por cual campo debe filtrar
            LProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void buscar_Registros() {

            string Sql = "select top 100 cProducto,x_producto,i_precioUnitario,m_activo from TPRODUCTO";
            if (txtBusqueda.Text != "") { 
                Sql = Sql + " where " + Campo  + " like '%" + txtBusqueda.Text  + "%'";
            }

            A.Consulta(Sql, "R");
            LProductos.DataSource = A.ds.Tables["R"];
            A.conexion.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            buscar_Registros();
        }
        private void LProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //esto es para cambiar el filtro por cabezera de la Grilla
            lbbusqueda.Text = LProductos.Columns[e.ColumnIndex].HeaderText;
            Campo = LProductos.Columns[e.ColumnIndex].Name.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABM_Producto("Regístro de Productos: Proceso - Agregar");
        }
        private void ABM_Producto(string titulo,string Proceso = "") {
            frmABMProductos FP = new frmABMProductos();
            AddOwnedForm(FP);
            FP.TopLevel = false;
            FP.Dock = DockStyle.Fill;
            this.Controls.Add(FP);
            this.Tag = FP;
            FP.BringToFront();
            FP.LbProceso.Text = titulo;
            FP.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (LProductos.Rows.Count > 0) { 
                ABM_Producto("Regístro de Productos: Proceso - Modificar");
            }
        }
    }
}
