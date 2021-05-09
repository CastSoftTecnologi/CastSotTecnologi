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
    public partial class frmABMpersonas : Form
    {
        Acceso A = new Acceso();
        public frmABMpersonas()
        {
            InitializeComponent();
        }

        private void frmABMpersonas_Load(object sender, EventArgs e)
        {

            Carga_combo();
            if (txtCodigo.Text != "")
            {
                Carga_Data(int.Parse(txtCodigo.Text));
            }
        }

        private void Carga_combo()
        {
            A.Consulta("Select 0 c_tipo_documento ,'<Seleccione>' x_sigla UNION select c_tipo_documento, x_sigla  from BTIPO_DOCUMENTO", "R");
            cboDoc.DataSource = A.ds.Tables["R"];
            cboDoc.ValueMember = "c_tipo_documento";
            cboDoc.DisplayMember = "x_sigla";
            A.conexion.Close();

            cboSexo.Items.Add("<Seleccione>");
            cboSexo.Items.Add("F");
            cboSexo.Items.Add("M");
            cboSexo.SelectedIndex = 0;


            A.Consulta("Select 0 c_pais, '<Seleccione>' x_pais UNION Select * from bpais", "R");
            cboPais.DataSource = A.ds.Tables["R"];
            cboPais.ValueMember = "c_pais";
            cboPais.DisplayMember = "x_pais";
            A.conexion.Close();

            A.Consulta("Select 0 c_rol, '<Seleccione>' x_rol UNION Select c_rol,x_rol from brol order by 1", "R");
            cboNivel.DataSource = A.ds.Tables["R"];
            cboNivel.ValueMember = "c_rol";
            cboNivel.DisplayMember = "x_rol";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnGuradar_Click(object sender, EventArgs e)
        {

            int tpersona = 3;

            if (GUsuario.Visible == true)
            {
                tpersona = 1;
            }
            if (GUsuario.Visible == false && txtNombreFantacias.Visible == false)
            {
                tpersona = 2;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Apellido", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Nombre", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNombreFantacias.Visible == true && txtNombreFantacias.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Nombre Fantasia del Proveedor", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboSexo.Text == "<Seleccione>" && txtNombreFantacias.Visible == false)
            {
                MessageBox.Show("Debe seleccionar el Sexo", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GUsuario.Visible == true && int.Parse(cboNivel.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar el Nivel de Usuario", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            A.Lectura("INS_BPERSONA " +
              "@c_tipo_persona	    = " + tpersona +
              //",@c_estado		    = " +
              ",@x_nombre			= '" + txtNombre.Text + "'" +
              ",@x_apellido		    = '" + txtApellido.Text + "'" +
              ",@x_nombre_fantasia  = '" + txtNombreFantacias.Text + "'" +
              ",@c_tipo_documento	= " + cboDoc.SelectedValue.ToString() +
              ",@n_documento		= '" + txtNroDoc.Text + "'" +
              //",@x_cuil			    = " +
              ",@f_nacimiento		= '" + Fnacimiento.Value.ToString("yyyyMMdd") + "'" +
              ",@t_sexo			    = '" + (cboSexo.Text == "<Seleccione>" ? "Null" : cboSexo.Text) + "'" +
              ",@c_nacionalidad	    = " + (int.Parse(cboPais.SelectedValue.ToString()) == 0 ? "NULL" : cboPais.SelectedValue.ToString()) +
              //",@n_legajo			= "  +
              ",@b_esUsuario		= " + (tpersona == 1 ? 1 : 0) +
              ",@xc_usuario		    = '" + txtUsuario.Text + "'" +
              ",@x_password		    = '" + txtClave.Text + "'" +
              ",@c_rol				= " + (int.Parse(cboNivel.SelectedValue.ToString()) == 0 ? "NULL" : cboNivel.SelectedValue.ToString()) +
              ",@m_habilitado = " + (chkActivo.Checked == true ? 1 : 0));
            A.conexion.Close();
            MessageBox.Show("Datos Gargados", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPersonas FP = Owner as frmPersonas;//Este permite actulizar la grilla haciendo que padre acepte la peticion de hijo
            FP.buscar_Registros();//esta funcion es de Padre frmPersonas pero la peticion de viene de frmABMProductos
            Dispose();
            Close();
        }
        private void Carga_Data(int Cod)
        {
            int tpersona = 3;

            if (GUsuario.Visible == true)
            {
                tpersona = 1;
            }
            if (GUsuario.Visible == false && txtNombreFantacias.Visible == false)
            {
                tpersona = 2;
            }
            A.Lectura("select P.*,U.xc_usuario, U.c_rol from BPERSONA P left join BUSUARIO U" +
                      " on U.c_persona = P.c_persona where p.c_tipo_persona = " + tpersona + " and P.c_persona = " + Cod);

            if (A.dr.Read())
            {
                txtNombre.Text = A.dr["x_nombre"].ToString();
                txtApellido.Text = A.dr["x_apellido"].ToString();
                txtNombreFantacias.Text = A.dr["x_nombre_fantasia"].ToString();
                cboDoc.SelectedValue = int.Parse(A.dr["c_tipo_documento"].ToString());
                txtNroDoc.Text = A.dr["n_documento"].ToString();
                Fnacimiento.Value = DateTime.Parse(A.dr["f_nacimiento"].ToString());
                cboSexo.Text = A.dr["t_sexo"].ToString();
                cboPais.SelectedValue = int.Parse(A.dr[""].ToString());
                txtUsuario.Text = A.dr["c_nacionalidad"].ToString();
                txtClave.Text = "***********************";
                cboNivel.SelectedValue = int.Parse(A.dr["c_rol"].ToString());
                chkActivo.Checked = int.Parse(A.dr["c_estado"].ToString()) == 1 ? true : false;
            }
            A.conexion.Close();
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            if (A.IsNumeric(txtNroDoc.Text) == false)
            {
                txtNroDoc.Text = "";
            }
        }
    }
}