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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            AbrirFormularios(new frmInicio());
        }
        public void AbrirFormularios(object formhijos)
        {//funcion para llamar a los formuliarios como Hijos
            if (PanelContenedor.Controls.Count > 0)
            {
                PanelContenedor.Controls.RemoveAt(0);
            }
            Form fm = formhijos as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill; //Esto acopla el fomilario al ancho y largo del contenedor
            this.PanelContenedor.Controls.Add(fm);//Es aqui cuando lo agregamos al contenedor
            this.PanelContenedor.Tag = fm;

            fm.Show();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmFacturacion());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmSalon());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
