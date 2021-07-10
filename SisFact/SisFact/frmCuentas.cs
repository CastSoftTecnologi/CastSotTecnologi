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
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Acceso.c_mesa = 0;
            Acceso.c_piso = 0;
            Dispose();
            Close();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            txtMesa.Text = Acceso.c_mesa.ToString();
            txtPiso.Text = Acceso.c_piso.ToString();
            txtMoso.Text = Acceso.x_usuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmFacturacion F = new frmFacturacion();
            F.ShowDialog();
            Dispose();
            Close();
        }
    }
}
