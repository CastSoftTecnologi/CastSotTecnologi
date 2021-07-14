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
        public string Proceso;
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            Carga_Producto();
            Carga_Catalago();
            lbFecha.Text = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy") +
           " Usuario: " + Acceso.x_usuario.ToString();
            if (Acceso.c_piso > 0) { 
                LbMesaPiso.Text = "Mesa: " + Acceso.c_mesa + " - Piso: " + Acceso.c_piso;
            }
            if (Acceso.c_cuenta > 0) { 
                Carga_detalle_cuenta();
            }
        }
        private void Carga_detalle_cuenta() {
            A.Lectura("exec getDetalleCuenta @c_cuenta = " + Acceso.c_cuenta);
            while (A.dr.Read()) {
                LDFactura.Rows.Add(LDFactura.Rows.Count + 1,
                           A.dr["c_Producto"].ToString(),
                           A.dr["x_producto"].ToString(),
                           1,
                           double.Parse(A.dr["PUnitario"].ToString()),
                           A.dr["c_Iva"].ToString(),
                           double.Parse(A.dr["i_iva"].ToString()),
                           0,
                           double.Parse(A.dr["PUnitario"].ToString()),
                           DateTime.Now.ToString("HH:mm:ss"));
            }
            A.conexion.Close();
        }
        private void Carga_Producto(int c_categoria = 0) {
            string sql = "Select c_Producto, x_producto from Tproducto where m_activo =1 and m_visible= 1";

            if (c_categoria > 0) {
                sql = sql + " and cCategoria = " + c_categoria;
            }
            A.Lectura(sql);

            Pproductos.Controls.Clear();
            while (A.dr.Read())
            {
                Button btnProducto = new Button();
                btnProducto.Name = A.dr["c_Producto"].ToString();
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

        private void Carga_Catalago() {
            A.Lectura("Select cCategoria, x_categoria from BCategoria");
            Pcatalogo.Controls.Clear();



            Button btnCatalogo1 = new Button();
            btnCatalogo1.Name = "0";
            btnCatalogo1.Text = "Todo";
            btnCatalogo1.Height = 50;
            btnCatalogo1.Width = 80;
            btnCatalogo1.ForeColor = Color.GreenYellow;
            btnCatalogo1.Font = new Font(btnCatalogo1.Font, FontStyle.Regular);
            btnCatalogo1.FlatStyle = FlatStyle.Flat;
            btnCatalogo1.Click += new EventHandler(btnCatalogo_Click);
            Pcatalogo.Controls.Add(btnCatalogo1);




            while (A.dr.Read()) {
                Button btnCatalogo = new Button();
                btnCatalogo.Name = A.dr["cCategoria"].ToString();
                btnCatalogo.Text = A.dr["x_categoria"].ToString();
                btnCatalogo.Height = 50;
                btnCatalogo.Width = 80;
                btnCatalogo.ForeColor = Color.GreenYellow;
                btnCatalogo.Font = new Font(btnCatalogo.Font, FontStyle.Regular);
                btnCatalogo.FlatStyle = FlatStyle.Flat;
                btnCatalogo.Click += new EventHandler(btnCatalogo_Click);
                Pcatalogo.Controls.Add(btnCatalogo);
            }
            A.conexion.Close();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Button btnCatalogo = sender as Button;
            Carga_Producto(int.Parse(btnCatalogo.Name.ToString()));
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            Button btnProductos = sender as Button;
            Carga_Grilla_DFacturacion(int.Parse(btnProductos.Name.ToString()));
        }
        private void Carga_Grilla_DFacturacion(int c_Producto) {

            A.Lectura("exec GET_PRODUCTOS @c_Producto = " + c_Producto.ToString());
            if (A.dr.Read()) {
                LDFactura.Rows.Add(LDFactura.Rows.Count + 1,
                               A.dr["c_Producto"].ToString(),
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
            int c_cuenta = 0;
            if (LDFactura.Rows.Count == 0) {
                MessageBox.Show( "Debe ingresar al menos un productos para crear una cuenta","Aviso...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }


            try
            {
                
                if (Proceso == "ADD")
                {
                    A.Lectura("exec INS_CUENTA @c_usuario = " + Acceso.c_usuario);
                    if (A.dr.Read() && A.dr["exito"].ToString() == "TRUE") {
                        c_cuenta = int.Parse(A.dr["idMensaje"].ToString());
                    }
                    A.conexion.Close();
                }
                else {
                    c_cuenta = Acceso.c_cuenta;
                    A.Ejecuta("Delete from Dcuenta where c_cuenta = " + Acceso.c_cuenta);
                }

                foreach (DataGridViewRow Fila in LDFactura.Rows)
                {
                    A.Ejecuta("exec INS_DCUENTA " +
                                    " @Indice = " + Fila.Cells["Item"].Value.ToString() +
                                    ",@c_cuenta = " + c_cuenta +
                                    ",@c_usuario = " + Acceso.c_usuario +
                                    ",@c_piso = " + Acceso.c_piso +
                                    ",@c_mesa = " + Acceso.c_mesa +
                                    ",@c_mozo= " + Acceso.c_usuario +
                                    ",@c_producto = " + Fila.Cells["c_producto"].Value.ToString() +
                                    ",@c_iva = " + Fila.Cells["c_iva"].Value.ToString() +
                                    ",@n_cantidad = " + Fila.Cells["Cant"].Value.ToString() +
                                    ",@Punitario = " + Fila.Cells["PUnitario"].Value.ToString().Replace(".", "").Replace(",", ".") +
                                    ",@PDescuento = " + Fila.Cells["Pdes"].Value.ToString().Replace(".", "").Replace(",", ".") +
                                    ",@total =  " + Fila.Cells["Total"].Value.ToString().Replace(".", "").Replace(",", ".")); ;
                }

                
                MessageBox.Show("Cuenta procesada","Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso", ex.Message);


            }
            A.conexion.Close();
        }
    }
}
