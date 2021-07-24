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
        Acceso A = new Acceso();
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
            Carga_grilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmFacturacion F = new frmFacturacion();
            F.Proceso = "ADD";
            F.ShowDialog();
            Dispose();
            Close();
        }
        private void Carga_grilla() {
            A.Consulta("exec Get_Cuentas @c_mesa = " + Acceso.c_mesa +
                        ",@c_piso = " + Acceso.c_piso, "R");

            Lcuentas.DataSource = A.ds.Tables["R"];
            if (Lcuentas.Rows.Count == 0) {
                btnModificar.Enabled = false;
            }
       
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmFacturacion F = new frmFacturacion();
            F.Proceso = "UPD";
            Acceso.c_cuenta = int.Parse(Lcuentas.CurrentRow.Cells["c_cuenta"].Value.ToString());
            F.ShowDialog();
            Dispose();
            Close();
        }
    }
}
