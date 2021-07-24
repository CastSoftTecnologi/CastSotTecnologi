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
    public partial class frmPersonas : Form
    {
        string Campo;
        public static int TUsuario;
        Acceso A = new Acceso();
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Cargar_Combo();
            buscar_Registros();


            switch (TUsuario)
            {
                case 1:
                    LbTusuario.Text = "Registros de Usuarios";
                    break;
                case 2:
                    LbTusuario.Text = "Registros de Clientes";
                    break;
                default:
                    LbTusuario.Text = "Registros de Proveedores";
                    break;
            }
        }
        private void Cargar_Combo()
        {
            lbbusqueda.Items.Add("Código");
            lbbusqueda.Items.Add("Nombre");
            lbbusqueda.Items.Add("Apellido");
            lbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            lbbusqueda.SelectedIndex = 0;
        }

        public void buscar_Registros()
        {

            string Sql = "select c_persona, x_nombre, x_apellido from Bpersona where c_tipo_persona = " + TUsuario;
            if (txtBusqueda.Text != "")
            {
                Sql = Sql + " and " + Campo + " like '%" + txtBusqueda.Text + "%'";
            }

            A.Consulta(Sql, "R");
            lpersonas.DataSource = A.ds.Tables["R"];
            A.conexion.Close();
        }

        private void Lclientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbbusqueda.Text = lpersonas.Columns[e.ColumnIndex].HeaderText;
            Campo = lpersonas.Columns[e.ColumnIndex].Name.ToString();
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            buscar_Registros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = "";
            switch (TUsuario)
            {
                case 1:
                    titulo = "Registro de Productos: Proceso - Agregar ";
                    break;
                case 2:
                    titulo = "Registro de Clientes:Proceso - Agregar ";
                    break;
                default:
                    titulo = "Registro de Proveedores: Proceso - Agregar ";
                    break;
            }
            ABM_Usuarios(titulo);
        }
        private void ABM_Usuarios(string titulo,bool Proceso = false) {
            frmABMpersonas FP = new frmABMpersonas();
            AddOwnedForm(FP);
            FP.TopLevel = false;
            FP.Dock = DockStyle.Fill;
            this.Controls.Add(FP);
            this.Tag = FP;
            FP.BringToFront();
            FP.LbProceso.Text = titulo;
            FP.GUsuario.Visible = true;
            if (TUsuario != 1) { FP.GUsuario.Visible = false; }
            if (TUsuario != 3) { FP.txtNombreFantacias.Visible = false;FP.LbNfantasia.Visible = false; }
            if (Proceso == true) {
                FP.txtCodigo.Text = lpersonas.CurrentRow.Cells[0].Value.ToString();
            }
            FP.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string titulo = "";
            switch (TUsuario)
            {
                case 1:
                    titulo = "Registro de Productos: Proceso - Modificar ";
                    break;
                case 2:
                    titulo = "Registro de Clientes:Proceso - Modificar ";
                    break;
                default:
                    titulo = "Registro de Proveedores: Proceso - Modificar ";
                    break;
            }
            ABM_Usuarios(titulo,true);
        }
    }
}

