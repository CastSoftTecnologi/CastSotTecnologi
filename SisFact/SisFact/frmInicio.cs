using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFact
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void fnHora_Tick(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToLongTimeString();
            LbFecha.Text = DateTime.Now.ToLongDateString();
            
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToLongTimeString();
            LbFecha.Text = DateTime.Now.ToLongDateString();
        }            
     
    }
}
