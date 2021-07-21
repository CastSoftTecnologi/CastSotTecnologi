using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFact
{
    
    public partial class frmABMmesas : Form
    {
        Acceso A = new Acceso();
        int VMesa;
        int CoorX;
        int CoorY;
        int Vpiso;
        byte[] bytes = Convert.FromBase64String(Acceso.ImdMesa);
        Image image;
        public frmABMmesas()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            A.Ejecuta("exec END_GENERA_NUEVA_MESA @Piso = " + Vpiso +
                                                 ",@X = '6'" +
                                                 ",@Y = '6'");
            Armo_Mesa();
        }
        private void Armo_Mesa() {
            A.Lectura("exec GET_MESAS_SALON @Piso = " + Vpiso.ToString()); ;

            Panel_Mesas.Controls.Clear();
            while (A.dr.Read()) { 
                Button CmdMesas = new Button();
                CmdMesas.Name = A.dr["mesa"].ToString();
                CmdMesas.Text = A.dr["x_mesa"].ToString();
                CmdMesas.Height = int.Parse(A.dr["Alto"].ToString());
                CmdMesas.Width = int.Parse(A.dr["Ancho"].ToString());  

                CmdMesas.Location = new Point(int.Parse(A.dr["X"].ToString()), int.Parse(A.dr["Y"].ToString()));
                CmdMesas.BackgroundImage = image;
                CmdMesas.BackgroundImageLayout = ImageLayout.Stretch;
                CmdMesas.FlatStyle = FlatStyle.Flat;
                CmdMesas.Click += new EventHandler(CmdMesas_Click);
                CmdMesas.MouseMove += new MouseEventHandler(CmdMesas_MouseMove);
                CmdMesas.MouseDown += new MouseEventHandler(CmdMesas_MouseDown);
                Panel_Mesas.Controls.Add(CmdMesas);
            }
            A.conexion.Close();
        }

        private void CmdMesas_MouseDown(object sender, MouseEventArgs e)
        {
            Button btnMesa = sender as Button;
            CoorX = e.X;
            CoorY = e.Y;
        }

        private void CmdMesas_MouseMove(object sender, MouseEventArgs e)
        {
            Button btnMesa = sender as Button;
            if (e.Button  == MouseButtons.Left) { 
                btnMesa.Location = new Point(btnMesa.Left + e.X - CoorX, btnMesa.Top + e.Y - CoorY);
               
            }
        }

        private void CmdMesas_Click(object sender, EventArgs e)
        {
            Button btnMesa = sender as Button;
            VMesa = int.Parse(btnMesa.Name.ToString());
            A.Lectura("exec GET_MESAS_SALON @Piso = " + Vpiso.ToString() + ", @mesa = " + VMesa);
            if (A.dr.Read()) { 
            txtNmesa.Text = A.dr["x_mesa"].ToString();
            }
            A.conexion.Close();
            A.Ejecuta("exec UPD_MESAS @X = '" + btnMesa.Location.X.ToString() + "', @Y = '" + btnMesa.Location.Y.ToString() + "', @Piso = " + Vpiso + ", @mesa = " + int.Parse(btnMesa.Name.ToString()));
        }
        private void Carga_imagen() {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
        }

        private void frmABMmesas_Load(object sender, EventArgs e)
        {
            Carga_imagen();
            Vpiso = 1;
            Armo_Mesa();
        }

        private void BtnPiso1_Click(object sender, EventArgs e)
        {
            Vpiso = 1;
            Armo_Mesa();
        }

        private void BtnPiso2_Click(object sender, EventArgs e)
        {
            Vpiso = 2;
            Armo_Mesa();
        }

        private void BtnPiso3_Click(object sender, EventArgs e)
        {
            Vpiso = 3;
            Armo_Mesa();
        }

        private void btnEdiMesa_Click(object sender, EventArgs e)
        {
            A.Ejecutar("exec UPD_MESAS @x_mesa = '" + txtNmesa.Text + "',@Piso = " + Vpiso + ",@mesa = " + VMesa);
            Armo_Mesa();
        }

        private void BtnAMas_Click(object sender, EventArgs e)
        {
            A.Ejecutar("exec UPD_MESAS @Alto = 1, @piso = " + Vpiso + ", @mesa = " + VMesa + ",@OP='+'");
            Armo_Mesa();
        }

        private void BtnAMenos_Click(object sender, EventArgs e)
        {
            A.Ejecutar("exec UPD_MESAS @Alto = 1, @piso = " + Vpiso + ", @mesa = " + VMesa + ",@OP='-'");
            Armo_Mesa();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            A.Ejecutar("exec UPD_MESAS @Ancho = 1, @piso = " + Vpiso + ", @mesa = " + VMesa + ",@OP='+'");
            Armo_Mesa();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            A.Ejecutar("exec UPD_MESAS @Ancho = 1, @piso = " + Vpiso + ", @mesa = " + VMesa + ",@OP='-'");
            Armo_Mesa();
        }
    }
}
