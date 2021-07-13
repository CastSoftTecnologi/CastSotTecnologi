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
    public partial class browserProductosNoVentas : Form
    {
        Acceso A = new Acceso();
        public browserProductosNoVentas()
        {
            InitializeComponent();
        }

        private void browserProductosNoVentas_Load(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }

        private void Cargar_Grilla() {
            A.Consulta("select c_Producto , xl_producto  from TPRODUCTO where m_venta = 0 " +
                      (txtBusqueda.Text !=""? " AND xl_nombre like '%" + txtBusqueda.Text  + "%'":"")
                , "R");
            Lproductos.DataSource = A.ds.Tables["R"];
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }



        private void Lproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Lproductos.Rows.Count > 0) {
                frmABMProductos FP = Owner as frmABMProductos;
                FP.txtCod.Text  = Lproductos.CurrentRow.Cells[0].Value.ToString();
                FP.txtDesc.Text  = Lproductos.CurrentRow.Cells[1].Value.ToString();
                FP.txtCant.Text = "1";
                FP.txtCant.Focus();
            }
            Dispose();
            Close();
        }


    }
}
