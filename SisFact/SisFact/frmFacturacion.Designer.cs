
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pproductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LDFactura = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuradar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LDFactura)).BeginInit();
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
            this.panel1.Controls.Add(this.btnGuradar);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.LDFactura);
            this.panel1.Location = new System.Drawing.Point(3, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 440);
            this.panel1.TabIndex = 20;
            // 
            // LDFactura
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LDFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LDFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LDFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.x_descripcion,
            this.Cant,
            this.PUnitario,
            this.Iva,
            this.Pdes,
            this.Total});
            this.LDFactura.Location = new System.Drawing.Point(3, 3);
            this.LDFactura.Name = "LDFactura";
            this.LDFactura.RowHeadersWidth = 25;
            this.LDFactura.Size = new System.Drawing.Size(562, 356);
            this.LDFactura.TabIndex = 2;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 40;
            // 
            // x_descripcion
            // 
            this.x_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x_descripcion.HeaderText = "Descripción";
            this.x_descripcion.Name = "x_descripcion";
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cant.";
            this.Cant.Name = "Cant";
            this.Cant.Width = 40;
            // 
            // PUnitario
            // 
            this.PUnitario.HeaderText = "P.Unitario";
            this.PUnitario.Name = "PUnitario";
            // 
            // Iva
            // 
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            this.Iva.Width = 40;
            // 
            // Pdes
            // 
            this.Pdes.HeaderText = "P.Desc";
            this.Pdes.Name = "Pdes";
            this.Pdes.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
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
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(580, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 73);
            this.panel2.TabIndex = 21;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1065, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LDFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Pproductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuradar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView LDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel2;
    }
}