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
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABM_Mesas();
        }
        private void ABM_Mesas() {
            frmABMmesas FP = new frmABMmesas();
            AddOwnedForm(FP);
            FP.TopLevel = false;
            FP.Dock = DockStyle.Fill;
            this.Controls.Add(FP);
            this.Tag = FP;
            FP.BringToFront();
            FP.Show();
        }
    }
}
