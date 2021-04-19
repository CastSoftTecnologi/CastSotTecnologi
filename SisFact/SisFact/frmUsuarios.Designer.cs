
namespace SisFact
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lclientes = new System.Windows.Forms.DataGridView();
            this.c_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbTusuario = new System.Windows.Forms.Label();
            this.lbbusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lclientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lclientes
            // 
            this.Lclientes.AllowUserToAddRows = false;
            this.Lclientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Lclientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Lclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lclientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Lclientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Lclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_persona,
            this.x_nombre,
            this.x_apellido});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Lclientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.Lclientes.EnableHeadersVisualStyles = false;
            this.Lclientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Lclientes.Location = new System.Drawing.Point(12, 192);
            this.Lclientes.MultiSelect = false;
            this.Lclientes.Name = "Lclientes";
            this.Lclientes.ReadOnly = true;
            this.Lclientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lclientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Lclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lclientes.Size = new System.Drawing.Size(939, 297);
            this.Lclientes.TabIndex = 8;
            this.Lclientes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Lclientes_ColumnHeaderMouseClick);
            // 
            // c_persona
            // 
            this.c_persona.HeaderText = "Código";
            this.c_persona.Name = "c_persona";
            this.c_persona.ReadOnly = true;
            // 
            // x_nombre
            // 
            this.x_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x_nombre.HeaderText = "Nombre";
            this.x_nombre.Name = "x_nombre";
            this.x_nombre.ReadOnly = true;
            // 
            // x_apellido
            // 
            this.x_apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x_apellido.HeaderText = "Apellido";
            this.x_apellido.Name = "x_apellido";
            this.x_apellido.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.LbTusuario);
            this.panel2.Controls.Add(this.lbbusqueda);
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 174);
            this.panel2.TabIndex = 9;
            // 
            // LbTusuario
            // 
            this.LbTusuario.AutoSize = true;
            this.LbTusuario.Font = new System.Drawing.Font("Yu Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.LbTusuario.ForeColor = System.Drawing.Color.Gray;
            this.LbTusuario.Location = new System.Drawing.Point(3, 0);
            this.LbTusuario.Name = "LbTusuario";
            this.LbTusuario.Size = new System.Drawing.Size(233, 27);
            this.LbTusuario.TabIndex = 9;
            this.LbTusuario.Text = "Registros de Usuarios";
            // 
            // lbbusqueda
            // 
            this.lbbusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lbbusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbbusqueda.Font = new System.Drawing.Font("Yu Gothic", 9.1F);
            this.lbbusqueda.ForeColor = System.Drawing.Color.Gray;
            this.lbbusqueda.FormattingEnabled = true;
            this.lbbusqueda.Location = new System.Drawing.Point(8, 105);
            this.lbbusqueda.Name = "lbbusqueda";
            this.lbbusqueda.Size = new System.Drawing.Size(118, 24);
            this.lbbusqueda.TabIndex = 8;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.White;
            this.txtBusqueda.Location = new System.Drawing.Point(132, 105);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(345, 25);
            this.txtBusqueda.TabIndex = 6;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.btnImprimir.Location = new System.Drawing.Point(827, 135);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 25);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.Gray;
            this.btnModificar.Location = new System.Drawing.Point(827, 104);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 25);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(827, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 25);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(963, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lclientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Lclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_apellido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbTusuario;
        private System.Windows.Forms.ComboBox lbbusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}