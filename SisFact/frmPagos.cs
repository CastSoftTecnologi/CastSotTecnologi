﻿using System;
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
    
    public partial class frmPagos : Form
    {
        Acceso A = new Acceso();
        public frmPagos()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
;        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            Carga_combo();
        }
        private void Carga_combo() {
            A.Consulta("Get_forma_pago", "R");
            cmbFormaPago.DataSource = A.ds.Tables["R"];
            cmbFormaPago.DisplayMember = "x_forma_Pago";
            cmbFormaPago.ValueMember = "c_forma_pago";
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

        }
    }
}
