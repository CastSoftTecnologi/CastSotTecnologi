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
    public partial class frmFacturacion : Form
    {

  
        Acceso A = new Acceso();
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            Carga_Producto();
        }
        private void Carga_Producto() {
            A.Lectura("Select cProducto, x_producto from Tproducto where m_activo =1 and m_visible= 1") ;

            Pproductos.Controls.Clear();
            while (A.dr.Read())
            {
                Button btnProducto = new Button();
                btnProducto.Name = A.dr["cProducto"].ToString();
                btnProducto.Text = A.dr["x_producto"].ToString();
                btnProducto.Height = 50;
                btnProducto.Width = 100;
                btnProducto.ForeColor = Color.White;
                btnProducto.Font = new Font(btnProducto.Font, FontStyle.Regular);
                btnProducto.FlatStyle = FlatStyle.Flat;
                btnProducto.Click += new EventHandler(btnProductos_Click);
                Pproductos.Controls.Add(btnProducto);
            }
            A.conexion.Close();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
           
        }
    }
}
