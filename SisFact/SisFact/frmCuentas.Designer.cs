
namespace SisFact
{
    partial class frmCuentas
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoso = new System.Windows.Forms.TextBox();
            this.Lcuentas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.c_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Lcuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Mesa:";
            // 
            // txtMesa
            // 
            this.txtMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesa.Enabled = false;
            this.txtMesa.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.ForeColor = System.Drawing.Color.White;
            this.txtMesa.Location = new System.Drawing.Point(68, 81);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(38, 25);
            this.txtMesa.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Moso:";
            // 
            // txtMoso
            // 
            this.txtMoso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMoso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoso.Enabled = false;
            this.txtMoso.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoso.ForeColor = System.Drawing.Color.White;
            this.txtMoso.Location = new System.Drawing.Point(68, 50);
            this.txtMoso.Name = "txtMoso";
            this.txtMoso.Size = new System.Drawing.Size(125, 25);
            this.txtMoso.TabIndex = 98;
            // 
            // Lcuentas
            // 
            this.Lcuentas.AllowUserToAddRows = false;
            this.Lcuentas.AllowUserToDeleteRows = false;
            this.Lcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lcuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_cuenta,
            this.x_estado,
            this.f_carga});
            this.Lcuentas.Location = new System.Drawing.Point(12, 112);
            this.Lcuentas.Name = "Lcuentas";
            this.Lcuentas.ReadOnly = true;
            this.Lcuentas.RowHeadersWidth = 25;
            this.Lcuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lcuentas.Size = new System.Drawing.Size(403, 224);
            this.Lcuentas.TabIndex = 102;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.Gray;
            this.btnModificar.Location = new System.Drawing.Point(311, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 25);
            this.btnModificar.TabIndex = 104;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(311, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 25);
            this.btnAgregar.TabIndex = 103;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Gray;
            this.btnSalir.Location = new System.Drawing.Point(160, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 25);
            this.btnSalir.TabIndex = 105;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "Piso:";
            // 
            // txtPiso
            // 
            this.txtPiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPiso.Enabled = false;
            this.txtPiso.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.ForeColor = System.Drawing.Color.White;
            this.txtPiso.Location = new System.Drawing.Point(155, 81);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(38, 25);
            this.txtPiso.TabIndex = 107;
            // 
            // c_cuenta
            // 
            this.c_cuenta.DataPropertyName = "c_cuenta";
            this.c_cuenta.HeaderText = "N.Cuenta";
            this.c_cuenta.Name = "c_cuenta";
            // 
            // x_estado
            // 
            this.x_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x_estado.DataPropertyName = "x_estado";
            this.x_estado.HeaderText = "Estado";
            this.x_estado.Name = "x_estado";
            // 
            // f_carga
            // 
            this.f_carga.DataPropertyName = "f_carga";
            this.f_carga.HeaderText = "F.Carga";
            this.f_carga.Name = "f_carga";
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(427, 379);
            this.ControlBox = false;
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Lcuentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lcuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMoso;
        private System.Windows.Forms.DataGridView Lcuentas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_carga;
    }
}