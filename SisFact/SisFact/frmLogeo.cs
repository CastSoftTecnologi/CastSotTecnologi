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
    public partial class frmLogeo : Form
    {
        Acceso A = new Acceso();
        public frmLogeo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void frmLogeo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "") {
                MessageBox.Show("Debe Ingresar el Usuario y Clave","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            A.Lectura("SP_Valida_Usario @Usuario = '" + txtUsuario.Text + "',@Clave ='" + txtClave.Text  + "'");
            if (A.dr.Read()) {
                if (A.dr[0].ToString() == "1")
                {
                    MessageBox.Show("Clave Correcta", "Aviso...");

                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "Aviso...");
                }

            }
            A.conexion.Close();
        }
    }
}
