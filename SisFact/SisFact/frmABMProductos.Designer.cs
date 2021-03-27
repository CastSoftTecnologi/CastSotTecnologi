
namespace SisFact
{
    partial class frmABMProductos
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.LbProceso = new System.Windows.Forms.Label();
            this.btnGuradar = new System.Windows.Forms.Button();
            this.TabProdutos = new System.Windows.Forms.TabControl();
            this.TbGenerales = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcBarra = new System.Windows.Forms.TextBox();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cboIVA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.chkFormula = new System.Windows.Forms.CheckBox();
            this.chkVenta = new System.Windows.Forms.CheckBox();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbbusqueda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.TbDetalle = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNfactnum = new System.Windows.Forms.TextBox();
            this.TabProdutos.SuspendLayout();
            this.TbGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Gray;
            this.btnsalir.Location = new System.Drawing.Point(539, 457);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(104, 25);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // LbProceso
            // 
            this.LbProceso.AutoSize = true;
            this.LbProceso.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProceso.ForeColor = System.Drawing.Color.Gray;
            this.LbProceso.Location = new System.Drawing.Point(12, 9);
            this.LbProceso.Name = "LbProceso";
            this.LbProceso.Size = new System.Drawing.Size(0, 21);
            this.LbProceso.TabIndex = 20;
            // 
            // btnGuradar
            // 
            this.btnGuradar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuradar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuradar.ForeColor = System.Drawing.Color.Gray;
            this.btnGuradar.Location = new System.Drawing.Point(429, 457);
            this.btnGuradar.Name = "btnGuradar";
            this.btnGuradar.Size = new System.Drawing.Size(104, 25);
            this.btnGuradar.TabIndex = 15;
            this.btnGuradar.Text = "Guardar";
            this.btnGuradar.UseVisualStyleBackColor = true;
            this.btnGuradar.Click += new System.EventHandler(this.btnGuradar_Click);
            // 
            // TabProdutos
            // 
            this.TabProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabProdutos.Controls.Add(this.TbGenerales);
            this.TabProdutos.Controls.Add(this.TbDetalle);
            this.TabProdutos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabProdutos.Location = new System.Drawing.Point(12, 12);
            this.TabProdutos.Name = "TabProdutos";
            this.TabProdutos.SelectedIndex = 0;
            this.TabProdutos.Size = new System.Drawing.Size(631, 424);
            this.TabProdutos.TabIndex = 34;
            // 
            // TbGenerales
            // 
            this.TbGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.TbGenerales.Controls.Add(this.label10);
            this.TbGenerales.Controls.Add(this.txtNfactnum);
            this.TbGenerales.Controls.Add(this.label9);
            this.TbGenerales.Controls.Add(this.txtStockMin);
            this.TbGenerales.Controls.Add(this.label8);
            this.TbGenerales.Controls.Add(this.txtcBarra);
            this.TbGenerales.Controls.Add(this.chkVisible);
            this.TbGenerales.Controls.Add(this.cboMarca);
            this.TbGenerales.Controls.Add(this.label7);
            this.TbGenerales.Controls.Add(this.chkActivo);
            this.TbGenerales.Controls.Add(this.cboIVA);
            this.TbGenerales.Controls.Add(this.label6);
            this.TbGenerales.Controls.Add(this.label5);
            this.TbGenerales.Controls.Add(this.txtPrecioU);
            this.TbGenerales.Controls.Add(this.chkFormula);
            this.TbGenerales.Controls.Add(this.chkVenta);
            this.TbGenerales.Controls.Add(this.cboUnidad);
            this.TbGenerales.Controls.Add(this.label4);
            this.TbGenerales.Controls.Add(this.cboCategoria);
            this.TbGenerales.Controls.Add(this.label3);
            this.TbGenerales.Controls.Add(this.label2);
            this.TbGenerales.Controls.Add(this.label1);
            this.TbGenerales.Controls.Add(this.txtNombreCorto);
            this.TbGenerales.Controls.Add(this.txtNombre);
            this.TbGenerales.Controls.Add(this.lbbusqueda);
            this.TbGenerales.Controls.Add(this.txtCodigo);
            this.TbGenerales.ForeColor = System.Drawing.Color.Black;
            this.TbGenerales.Location = new System.Drawing.Point(4, 22);
            this.TbGenerales.Name = "TbGenerales";
            this.TbGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.TbGenerales.Size = new System.Drawing.Size(623, 398);
            this.TbGenerales.TabIndex = 0;
            this.TbGenerales.Text = "Datos Generales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(254, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Stock. Min:";
            // 
            // txtStockMin
            // 
            this.txtStockMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockMin.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMin.ForeColor = System.Drawing.Color.White;
            this.txtStockMin.Location = new System.Drawing.Point(358, 123);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(108, 25);
            this.txtStockMin.TabIndex = 4;
            this.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(254, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Código Barra:";
            // 
            // txtcBarra
            // 
            this.txtcBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtcBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcBarra.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcBarra.ForeColor = System.Drawing.Color.White;
            this.txtcBarra.Location = new System.Drawing.Point(358, 92);
            this.txtcBarra.Name = "txtcBarra";
            this.txtcBarra.Size = new System.Drawing.Size(168, 25);
            this.txtcBarra.TabIndex = 3;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVisible.ForeColor = System.Drawing.Color.White;
            this.chkVisible.Location = new System.Drawing.Point(29, 283);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(62, 17);
            this.chkVisible.TabIndex = 12;
            this.chkVisible.Text = "Visible  ";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.ForeColor = System.Drawing.Color.Gray;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(132, 123);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(108, 21);
            this.cboMarca.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Marca:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(29, 260);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Activo  ";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboIVA
            // 
            this.cboIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIVA.ForeColor = System.Drawing.Color.Gray;
            this.cboIVA.FormattingEnabled = true;
            this.cboIVA.Location = new System.Drawing.Point(132, 340);
            this.cboIVA.Name = "cboIVA";
            this.cboIVA.Size = new System.Drawing.Size(108, 21);
            this.cboIVA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "IVA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Precio.U:";
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtPrecioU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioU.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioU.ForeColor = System.Drawing.Color.White;
            this.txtPrecioU.Location = new System.Drawing.Point(132, 309);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(108, 25);
            this.txtPrecioU.TabIndex = 13;
            this.txtPrecioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkFormula
            // 
            this.chkFormula.AutoSize = true;
            this.chkFormula.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFormula.ForeColor = System.Drawing.Color.White;
            this.chkFormula.Location = new System.Drawing.Point(28, 237);
            this.chkFormula.Name = "chkFormula";
            this.chkFormula.Size = new System.Drawing.Size(63, 17);
            this.chkFormula.TabIndex = 10;
            this.chkFormula.Text = "Formula";
            this.chkFormula.UseVisualStyleBackColor = true;
            // 
            // chkVenta
            // 
            this.chkVenta.AutoSize = true;
            this.chkVenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVenta.ForeColor = System.Drawing.Color.White;
            this.chkVenta.Location = new System.Drawing.Point(28, 214);
            this.chkVenta.Name = "chkVenta";
            this.chkVenta.Size = new System.Drawing.Size(63, 17);
            this.chkVenta.TabIndex = 9;
            this.chkVenta.Text = "Venta   ";
            this.chkVenta.UseVisualStyleBackColor = true;
            // 
            // cboUnidad
            // 
            this.cboUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnidad.ForeColor = System.Drawing.Color.Gray;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(132, 177);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(108, 21);
            this.cboUnidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Unidad:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.ForeColor = System.Drawing.Color.Gray;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(132, 150);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(108, 21);
            this.cboCategoria.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre Corto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreCorto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCorto.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCorto.ForeColor = System.Drawing.Color.White;
            this.txtNombreCorto.Location = new System.Drawing.Point(132, 92);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(108, 25);
            this.txtNombreCorto.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(132, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(394, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lbbusqueda
            // 
            this.lbbusqueda.AutoSize = true;
            this.lbbusqueda.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbusqueda.ForeColor = System.Drawing.Color.White;
            this.lbbusqueda.Location = new System.Drawing.Point(28, 30);
            this.lbbusqueda.Name = "lbbusqueda";
            this.lbbusqueda.Size = new System.Drawing.Size(49, 17);
            this.lbbusqueda.TabIndex = 42;
            this.lbbusqueda.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(132, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 25);
            this.txtCodigo.TabIndex = 0;
            // 
            // TbDetalle
            // 
            this.TbDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.TbDetalle.Location = new System.Drawing.Point(4, 22);
            this.TbDetalle.Name = "TbDetalle";
            this.TbDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.TbDetalle.Size = new System.Drawing.Size(623, 398);
            this.TbDetalle.TabIndex = 1;
            this.TbDetalle.Text = "Detalles de Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(254, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "F. Numérico";
            // 
            // txtNfactnum
            // 
            this.txtNfactnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNfactnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNfactnum.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNfactnum.ForeColor = System.Drawing.Color.White;
            this.txtNfactnum.Location = new System.Drawing.Point(358, 151);
            this.txtNfactnum.Name = "txtNfactnum";
            this.txtNfactnum.Size = new System.Drawing.Size(108, 25);
            this.txtNfactnum.TabIndex = 5;
            this.txtNfactnum.Text = "1";
            this.txtNfactnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNfactnum.TextChanged += new System.EventHandler(this.txtNfactnum_TextChanged);
            // 
            // frmABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(655, 494);
            this.Controls.Add(this.TabProdutos);
            this.Controls.Add(this.btnGuradar);
            this.Controls.Add(this.LbProceso);
            this.Controls.Add(this.btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmABMProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABMProductos";
            this.Load += new System.EventHandler(this.frmABMProductos_Load);
            this.TabProdutos.ResumeLayout(false);
            this.TbGenerales.ResumeLayout(false);
            this.TbGenerales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.Label LbProceso;
        private System.Windows.Forms.Button btnGuradar;
        private System.Windows.Forms.TabControl TabProdutos;
        private System.Windows.Forms.TabPage TbGenerales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbbusqueda;
        private System.Windows.Forms.TabPage TbDetalle;
        public System.Windows.Forms.TextBox txtStockMin;
        public System.Windows.Forms.TextBox txtcBarra;
        public System.Windows.Forms.CheckBox chkVisible;
        public System.Windows.Forms.ComboBox cboMarca;
        public System.Windows.Forms.CheckBox chkActivo;
        public System.Windows.Forms.ComboBox cboIVA;
        public System.Windows.Forms.TextBox txtPrecioU;
        public System.Windows.Forms.CheckBox chkFormula;
        public System.Windows.Forms.CheckBox chkVenta;
        public System.Windows.Forms.ComboBox cboUnidad;
        public System.Windows.Forms.ComboBox cboCategoria;
        public System.Windows.Forms.TextBox txtNombreCorto;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtNfactnum;
    }
}