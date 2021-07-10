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
    public partial class frmSalon : Form
    {
        Acceso A = new Acceso();
        int Vpiso;
        byte[] bytes = Convert.FromBase64String(Acceso.ImdMesa);
        Image image;
        public frmSalon()
        {
            InitializeComponent();
        }

        private void frmSalon_Load(object sender, EventArgs e)
        {
            Vpiso = 1;
            Carga_imagen();
            Armo_Mesa();

        }
        private void Armo_Mesa()
        {
            A.Lectura("exec GET_MESAS_SALON @Piso = " + Vpiso.ToString()); 

            Panel_Mesas.Controls.Clear();
            while (A.dr.Read())
            {
                Button CmdMesas = new Button();
                CmdMesas.Name = A.dr["mesa"].ToString();
                CmdMesas.Text = A.dr["x_mesa"].ToString();
                CmdMesas.Height = int.Parse(A.dr["Alto"].ToString());
                CmdMesas.Width = int.Parse(A.dr["Ancho"].ToString());   // CmdMesas As New Button()

                CmdMesas.Location = new Point(int.Parse(A.dr["X"].ToString()), int.Parse(A.dr["Y"].ToString()));
                CmdMesas.BackgroundImage = image;
                CmdMesas.BackgroundImageLayout = ImageLayout.Stretch;
                CmdMesas.FlatStyle = FlatStyle.Flat;
                CmdMesas.Click += new EventHandler(CmdMesas_Click);
                Panel_Mesas.Controls.Add(CmdMesas);
            }
            A.conexion.Close();
        }

        private void CmdMesas_Click(object sender, EventArgs e)
        {
            Button btnMesa = sender as Button;
            LogeoCuenta F = new LogeoCuenta();
            Acceso.c_mesa = int.Parse(btnMesa.Name.ToString());
            Acceso.c_piso = Vpiso;
            F.ShowDialog();
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
        private void Carga_imagen()
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
        }


    }
}
