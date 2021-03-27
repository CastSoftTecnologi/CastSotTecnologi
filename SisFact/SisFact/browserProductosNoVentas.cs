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
            A.Consulta("select cProducto , xl_producto  from TPRODUCTO where m_venta = 0 " +
                      (txtBusqueda.Text !=""? " AND xl_nombre like '%" + txtBusqueda.Text  + "%'":"")
                , "R");
            Lproductos.DataSource = A.ds.Tables["R"];
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
