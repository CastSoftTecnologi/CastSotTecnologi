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
            lbFecha.Text = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy") +
           " Usuario: " + Acceso.x_usuario.ToString();
            if (Acceso.c_piso > 0) { 
                LbMesaPiso.Text = "Mesa: " + Acceso.c_mesa + " - Piso: " + Acceso.c_piso;
            }
        }
        private void Carga_Producto() {
            A.Lectura("Select cProducto, x_producto from Tproducto where m_activo =1 and m_visible= 1");

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

            Button btnProductos = sender as Button;
            Carga_Grilla_DFacturacion(int.Parse(btnProductos.Name.ToString()));
        }
        private void Carga_Grilla_DFacturacion(int cProducto) {

            A.Lectura("exec GET_PRODUCTOS @cProducto = " + cProducto.ToString());
            if (A.dr.Read()) {
                LDFactura.Rows.Add(LDFactura.Rows.Count + 1,
                               A.dr["cProducto"].ToString(),
                               A.dr["x_producto"].ToString(),
                               1,
                               double.Parse(A.dr["i_precioUnitario"].ToString()),
                               A.dr["cIva"].ToString(),
                               double.Parse(A.dr["nIva"].ToString()),
                               0,
                               double.Parse(A.dr["i_precioUnitario"].ToString()),
                               DateTime.Now.ToString("HH:mm:ss"));
            }
            A.conexion.Close();
            Totalizo();
        }

        private void LDFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Totalizo();
        }
        private void Totalizo() {
            int i = 1;
            double vtotal = 0;
            foreach (DataGridViewRow Fila in LDFactura.Rows)
            {
                Fila.Cells[0].Value = i++;
                vtotal = vtotal + double.Parse(Fila.Cells["Total"].Value.ToString());
            }
            txtTotal.Text = vtotal.ToString("#,##0.00");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Acceso.c_mesa = 0;
            Acceso.c_piso = 0;
            Dispose();
            Close();
        }

        private void btnGuradar_Click(object sender, EventArgs e)
        {

            if (LDFactura.Rows.Count == 0) {
                MessageBox.Show( "Debe ingresar al menos un productos para crear una cuenta","Aviso...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            A.conexion.Open();
            A.Transaccion = A.conexion.BeginTransaction();
            try
            {
                A.Ejecuta_trans("exec INS_CUENTA @c_estado_cuenta = 1,@c_usuario = " + Acceso.c_usuario);
                foreach (DataGridViewRow Fila in LDFactura.Rows)
                {
                    A.Ejecuta_trans("exec INS_DCUENTA " +
                                    " @Indice = " + Fila.Cells["Item"].Value.ToString() +
                                    ",@c_usuario = " + Acceso.c_usuario +
                                    ",@c_piso = " + Acceso.c_piso +
                                    ",@c_mesa = " + Acceso.c_mesa +
                                    ",@c_mozo= " + Acceso.c_usuario +
                                    ",@c_producto = " + Fila.Cells["c_producto"].Value.ToString() +
                                    ",@c_iva = " + Fila.Cells["c_iva"].Value.ToString() +
                                    ",@n_cantidad = " + Fila.Cells["Cant"].Value.ToString() +
                                    ",@f_carga = '" + DateTime.Parse(Fila.Cells["Hora"].Value.ToString()).ToString("HH:MM:ss") + "'" +
                                    ",@Punitario = " + Fila.Cells["PUnitario"].Value.ToString().Replace(".","").Replace(",",".") +
                                    ",@PDescuento = " + Fila.Cells["Pdes"].Value.ToString().Replace(".", "").Replace(",", ".") +
                                    ",@total =  " + Fila.Cells["Total"].Value.ToString().Replace(".", "").Replace(",", "."));
                }

                A.Transaccion.Commit();
                MessageBox.Show("Cuenta procesada","Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso", ex.Message);

                A.Transaccion.Rollback();
            }
            A.conexion.Close();
        }
    }
}
