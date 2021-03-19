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

            A.Lectura("loginDB @xc_usuario = '" + txtUsuario.Text + "',@x_password ='" + txtClave.Text  + "'");
            if (A.dr.Read())
            {
                frmMenuPrincipal Menu = new frmMenuPrincipal();

                Acceso.x_usuario = A.dr["xc_usuario"].ToString();
                Menu.Show();
                A.conexion.Close();
                return;
            }
            else
            { 
                A.conexion.Close();
                MessageBox.Show("Usuario o clave incorrecto","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
