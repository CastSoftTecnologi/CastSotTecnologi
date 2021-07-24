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
    public partial class LogeoCuenta : Form
    {
        Acceso A = new Acceso();
        public LogeoCuenta()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Acceso.c_mesa = 0;
            Acceso.c_piso = 0;
            Dispose();
            Close();
        }

        private void brnAceptar_Click(object sender, EventArgs e)
        {
            A.Lectura("loginDB @xc_usuario = '" + txtUsuario.Text + "'" +
                                        ",@x_password = '" + txtClave.Text  +"'");
            if (A.dr.Read())
            {
                Acceso.x_usuario = A.dr["xc_usuario"].ToString();
                Acceso.c_usuario = int.Parse(A.dr["c_usuario"].ToString());
                A.conexion.Close();
                frmCuentas F = new frmCuentas();
                Dispose();
                Close();
                F.ShowDialog();

            }
            else {
                MessageBox.Show("Aviso", "Usuario y clave no registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            A.conexion.Close();
        }

        private void LogeoCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
