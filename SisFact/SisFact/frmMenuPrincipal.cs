using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SisFact
{
    public partial class frmMenuPrincipal : Form
    {
        public string llamadasForm;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirFormularios(object formhijos) {//funcion para llamar a los formuliarios como Hijos
            if (PanelContenedor.Controls.Count > 0) {
                PanelContenedor.Controls.RemoveAt(0);
            }
            Form fm = formhijos as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill; //Esto acopla el fomilario al ancho y largo del contenedor
            this.PanelContenedor.Controls.Add(fm);//Es aqui cuando lo agregamos al contenedor
            this.PanelContenedor.Tag = fm;
 
            fm.Show();
            
        }
        private void brnCerrarV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam, int lParam);

        private void Bartitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (SubMenuReportes.Visible == true)
            {
                SubMenuReportes.Visible = false;
            }
            else
            {
                SubMenuReportes.Visible = true;
            }
        }

        private void btncloseMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmProductos());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmInicio());
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            frmLogeo Logeo = new frmLogeo();//Instancio el logeo para cerrarlo
            Logeo.Dispose();
            Logeo.Close();
            AbrirFormularios(new frmInicio());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmPersonas.TUsuario = 2;
            AbrirFormularios(new frmPersonas());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmPersonas.TUsuario = 1;
            AbrirFormularios(new frmPersonas());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmPersonas.TUsuario = 3;
            AbrirFormularios(new frmPersonas());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmMesas());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            frmVentas V = new frmVentas();
            V.ShowDialog();
        }
    }
}
