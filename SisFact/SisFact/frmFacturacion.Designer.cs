
namespace SisFact
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pproductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuradar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.LDFactura = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnularCuenta = new System.Windows.Forms.Button();
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.LbMesaPiso = new System.Windows.Forms.Label();
            this.btnCambioMesa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LDFactura)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pproductos
            // 
            this.Pproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pproductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pproductos.Location = new System.Drawing.Point(580, 107);
            this.Pproductos.Name = "Pproductos";
            this.Pproductos.Size = new System.Drawing.Size(473, 359);
            this.Pproductos.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnGuradar);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.LDFactura);
            this.panel1.Location = new System.Drawing.Point(3, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 440);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(425, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "$";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.LemonChiffon;
            this.txtTotal.Location = new System.Drawing.Point(454, 365);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(111, 31);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuradar
            // 
            this.btnGuradar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuradar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuradar.ForeColor = System.Drawing.Color.Gray;
            this.btnGuradar.Location = new System.Drawing.Point(196, 403);
            this.btnGuradar.Name = "btnGuradar";
            this.btnGuradar.Size = new System.Drawing.Size(104, 25);
            this.btnGuradar.TabIndex = 19;
            this.btnGuradar.Text = "Guardar";
            this.btnGuradar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Gray;
            this.btnsalir.Location = new System.Drawing.Point(306, 403);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(104, 25);
            this.btnsalir.TabIndex = 20;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // LDFactura
            // 
            this.LDFactura.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LDFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LDFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LDFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.x_descripcion,
            this.Cant,
            this.PUnitario,
            this.Iva,
            this.Pdes,
            this.Total,
            this.Hora});
            this.LDFactura.Location = new System.Drawing.Point(3, 3);
            this.LDFactura.Name = "LDFactura";
            this.LDFactura.ReadOnly = true;
            this.LDFactura.RowHeadersWidth = 25;
            this.LDFactura.Size = new System.Drawing.Size(562, 356);
            this.LDFactura.TabIndex = 2;
            this.LDFactura.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.LDFactura_RowsRemoved);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 35;
            // 
            // x_descripcion
            // 
            this.x_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x_descripcion.HeaderText = "Descripción";
            this.x_descripcion.Name = "x_descripcion";
            this.x_descripcion.ReadOnly = true;
            // 
            // Cant
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Cant.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cant.HeaderText = "Cant.";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 40;
            // 
            // PUnitario
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.PUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.PUnitario.HeaderText = "P.Unitario";
            this.PUnitario.Name = "PUnitario";
            this.PUnitario.ReadOnly = true;
            this.PUnitario.Width = 75;
            // 
            // Iva
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Iva.DefaultCellStyle = dataGridViewCellStyle4;
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 40;
            // 
            // Pdes
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Pdes.DefaultCellStyle = dataGridViewCellStyle5;
            this.Pdes.HeaderText = "P.Desc";
            this.Pdes.Name = "Pdes";
            this.Pdes.ReadOnly = true;
            this.Pdes.Width = 40;
            // 
            // Total
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 75;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnCambioMesa);
            this.panel2.Controls.Add(this.btnAnularCuenta);
            this.panel2.Controls.Add(this.btnCerrarCuenta);
            this.panel2.Location = new System.Drawing.Point(580, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 73);
            this.panel2.TabIndex = 21;
            // 
            // btnAnularCuenta
            // 
            this.btnAnularCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnularCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularCuenta.ForeColor = System.Drawing.Color.Gray;
            this.btnAnularCuenta.Location = new System.Drawing.Point(94, 4);
            this.btnAnularCuenta.Name = "btnAnularCuenta";
            this.btnAnularCuenta.Size = new System.Drawing.Size(85, 57);
            this.btnAnularCuenta.TabIndex = 22;
            this.btnAnularCuenta.Text = "Anular Cuenta";
            this.btnAnularCuenta.UseVisualStyleBackColor = true;
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCuenta.ForeColor = System.Drawing.Color.Gray;
            this.btnCerrarCuenta.Location = new System.Drawing.Point(3, 4);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(85, 57);
            this.btnCerrarCuenta.TabIndex = 21;
            this.btnCerrarCuenta.Text = "Cerrar Cuenta";
            this.btnCerrarCuenta.UseVisualStyleBackColor = true;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbFecha.Location = new System.Drawing.Point(12, 9);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(71, 25);
            this.lbFecha.TabIndex = 24;
            this.lbFecha.Text = "Fecha:";
            // 
            // LbMesaPiso
            // 
            this.LbMesaPiso.AutoSize = true;
            this.LbMesaPiso.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMesaPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LbMesaPiso.Location = new System.Drawing.Point(12, 54);
            this.LbMesaPiso.Name = "LbMesaPiso";
            this.LbMesaPiso.Size = new System.Drawing.Size(0, 25);
            this.LbMesaPiso.TabIndex = 25;
            this.LbMesaPiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCambioMesa
            // 
            this.btnCambioMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambioMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioMesa.ForeColor = System.Drawing.Color.Gray;
            this.btnCambioMesa.Location = new System.Drawing.Point(185, 4);
            this.btnCambioMesa.Name = "btnCambioMesa";
            this.btnCambioMesa.Size = new System.Drawing.Size(85, 57);
            this.btnCambioMesa.TabIndex = 23;
            this.btnCambioMesa.Text = "Cambio de Mesa";
            this.btnCambioMesa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(276, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 57);
            this.button1.TabIndex = 24;
            this.button1.Text = "Unir Mesas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(367, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 57);
            this.button2.TabIndex = 25;
            this.button2.Text = "Movimiento de Caja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1065, 559);
            this.Controls.Add(this.LbMesaPiso);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LDFactura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Pproductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuradar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView LDFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnAnularCuenta;
        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.Label LbMesaPiso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCambioMesa;
    }
}