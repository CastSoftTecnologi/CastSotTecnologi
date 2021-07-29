
namespace SisFact
{
    partial class frmPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.lbbusqueda = new System.Windows.Forms.Label();
            this.txtNcuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEntidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.ForeColor = System.Drawing.Color.Gray;
            this.btnProcesar.Location = new System.Drawing.Point(234, 151);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(72, 32);
            this.btnProcesar.TabIndex = 21;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Gray;
            this.btnsalir.Location = new System.Drawing.Point(312, 151);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(72, 32);
            this.btnsalir.TabIndex = 22;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(131, 42);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(231, 21);
            this.cmbFormaPago.TabIndex = 23;
            this.cmbFormaPago.SelectedValueChanged += new System.EventHandler(this.cmbFormaPago_SelectedValueChanged);
            this.cmbFormaPago.Leave += new System.EventHandler(this.cmbFormaPago_Leave);
            // 
            // lbbusqueda
            // 
            this.lbbusqueda.AutoSize = true;
            this.lbbusqueda.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbusqueda.ForeColor = System.Drawing.Color.White;
            this.lbbusqueda.Location = new System.Drawing.Point(23, 12);
            this.lbbusqueda.Name = "lbbusqueda";
            this.lbbusqueda.Size = new System.Drawing.Size(82, 17);
            this.lbbusqueda.TabIndex = 92;
            this.lbbusqueda.Text = "N°.Cuenta:";
            // 
            // txtNcuenta
            // 
            this.txtNcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNcuenta.Enabled = false;
            this.txtNcuenta.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNcuenta.Location = new System.Drawing.Point(131, 11);
            this.txtNcuenta.Name = "txtNcuenta";
            this.txtNcuenta.Size = new System.Drawing.Size(108, 25);
            this.txtNcuenta.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Forma de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "Monto TotaL:";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(131, 96);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(108, 25);
            this.txtMonto.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 97;
            this.label3.Text = "Entidad:";
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntidad.Enabled = false;
            this.cmbEntidad.FormattingEnabled = true;
            this.cmbEntidad.Location = new System.Drawing.Point(131, 69);
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.Size = new System.Drawing.Size(231, 21);
            this.cmbEntidad.TabIndex = 96;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(396, 195);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEntidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbbusqueda);
            this.Controls.Add(this.txtNcuenta);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label lbbusqueda;
        public System.Windows.Forms.TextBox txtNcuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEntidad;
    }
}