﻿
namespace SisFact
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.Bartitulo = new System.Windows.Forms.Panel();
            this.BarMenu = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.brnCerrarV = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SubMenuReportes = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnReportVentas = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnReportCompras = new System.Windows.Forms.Button();
            this.btncloseMenu = new System.Windows.Forms.PictureBox();
            this.Bartitulo.SuspendLayout();
            this.BarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SubMenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncloseMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Bartitulo
            // 
            this.Bartitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Bartitulo.Controls.Add(this.btnRestaurar);
            this.Bartitulo.Controls.Add(this.brnCerrarV);
            this.Bartitulo.Controls.Add(this.btnMinimizar);
            this.Bartitulo.Controls.Add(this.BtnMaximizar);
            this.Bartitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bartitulo.Location = new System.Drawing.Point(0, 0);
            this.Bartitulo.Name = "Bartitulo";
            this.Bartitulo.Size = new System.Drawing.Size(869, 35);
            this.Bartitulo.TabIndex = 0;
            this.Bartitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bartitulo_MouseDown);
            // 
            // BarMenu
            // 
            this.BarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarMenu.Controls.Add(this.btncloseMenu);
            this.BarMenu.Controls.Add(this.SubMenuReportes);
            this.BarMenu.Controls.Add(this.Logo);
            this.BarMenu.Controls.Add(this.panel7);
            this.BarMenu.Controls.Add(this.btnReportes);
            this.BarMenu.Controls.Add(this.panel6);
            this.BarMenu.Controls.Add(this.btnCompras);
            this.BarMenu.Controls.Add(this.panel5);
            this.BarMenu.Controls.Add(this.btnUsuarios);
            this.BarMenu.Controls.Add(this.panel4);
            this.BarMenu.Controls.Add(this.BtnVentas);
            this.BarMenu.Controls.Add(this.panel3);
            this.BarMenu.Controls.Add(this.btnProducto);
            this.BarMenu.Controls.Add(this.panel1);
            this.BarMenu.Controls.Add(this.btnClientes);
            this.BarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarMenu.Location = new System.Drawing.Point(0, 35);
            this.BarMenu.Name = "BarMenu";
            this.BarMenu.Size = new System.Drawing.Size(220, 504);
            this.BarMenu.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(220, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(649, 504);
            this.PanelContenedor.TabIndex = 2;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(813, 9);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMaximizar.TabIndex = 0;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(787, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // brnCerrarV
            // 
            this.brnCerrarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnCerrarV.Image = ((System.Drawing.Image)(resources.GetObject("brnCerrarV.Image")));
            this.brnCerrarV.Location = new System.Drawing.Point(839, 9);
            this.brnCerrarV.Name = "brnCerrarV";
            this.brnCerrarV.Size = new System.Drawing.Size(20, 20);
            this.brnCerrarV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brnCerrarV.TabIndex = 2;
            this.brnCerrarV.TabStop = false;
            this.brnCerrarV.Click += new System.EventHandler(this.brnCerrarV_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(813, 9);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 92);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(202, 31);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 31);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(3, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 31);
            this.panel3.TabIndex = 4;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(12, 129);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(202, 31);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 31);
            this.panel4.TabIndex = 6;
            // 
            // BtnVentas
            // 
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = ((System.Drawing.Image)(resources.GetObject("BtnVentas.Image")));
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(12, 166);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(202, 31);
            this.BtnVentas.TabIndex = 5;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 31);
            this.panel5.TabIndex = 8;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 203);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(202, 31);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(3, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 31);
            this.panel6.TabIndex = 10;
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(12, 240);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(202, 31);
            this.btnCompras.TabIndex = 9;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(3, 277);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(6, 31);
            this.panel7.TabIndex = 12;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(12, 277);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(202, 31);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(211, 83);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // SubMenuReportes
            // 
            this.SubMenuReportes.Controls.Add(this.panel10);
            this.SubMenuReportes.Controls.Add(this.btnReportCompras);
            this.SubMenuReportes.Controls.Add(this.panel9);
            this.SubMenuReportes.Controls.Add(this.btnReportVentas);
            this.SubMenuReportes.Location = new System.Drawing.Point(35, 314);
            this.SubMenuReportes.Name = "SubMenuReportes";
            this.SubMenuReportes.Size = new System.Drawing.Size(185, 72);
            this.SubMenuReportes.TabIndex = 14;
            this.SubMenuReportes.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 31);
            this.panel9.TabIndex = 14;
            // 
            // btnReportVentas
            // 
            this.btnReportVentas.FlatAppearance.BorderSize = 0;
            this.btnReportVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportVentas.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportVentas.ForeColor = System.Drawing.Color.White;
            this.btnReportVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportVentas.Location = new System.Drawing.Point(13, 3);
            this.btnReportVentas.Name = "btnReportVentas";
            this.btnReportVentas.Size = new System.Drawing.Size(166, 31);
            this.btnReportVentas.TabIndex = 13;
            this.btnReportVentas.Text = "Reportes Ventas";
            this.btnReportVentas.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(4, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 31);
            this.panel10.TabIndex = 16;
            // 
            // btnReportCompras
            // 
            this.btnReportCompras.FlatAppearance.BorderSize = 0;
            this.btnReportCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportCompras.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportCompras.ForeColor = System.Drawing.Color.White;
            this.btnReportCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportCompras.Location = new System.Drawing.Point(14, 35);
            this.btnReportCompras.Name = "btnReportCompras";
            this.btnReportCompras.Size = new System.Drawing.Size(166, 31);
            this.btnReportCompras.TabIndex = 15;
            this.btnReportCompras.Text = "Reportes Ventas";
            this.btnReportCompras.UseVisualStyleBackColor = true;
            // 
            // btncloseMenu
            // 
            this.btncloseMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncloseMenu.Image = ((System.Drawing.Image)(resources.GetObject("btncloseMenu.Image")));
            this.btncloseMenu.Location = new System.Drawing.Point(35, 435);
            this.btncloseMenu.Name = "btncloseMenu";
            this.btncloseMenu.Size = new System.Drawing.Size(58, 57);
            this.btncloseMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncloseMenu.TabIndex = 15;
            this.btncloseMenu.TabStop = false;
            this.btncloseMenu.Click += new System.EventHandler(this.btncloseMenu_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 539);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarMenu);
            this.Controls.Add(this.Bartitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.Bartitulo.ResumeLayout(false);
            this.BarMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SubMenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncloseMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bartitulo;
        private System.Windows.Forms.PictureBox brnCerrarV;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.Panel BarMenu;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel SubMenuReportes;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnReportCompras;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnReportVentas;
        private System.Windows.Forms.PictureBox btncloseMenu;
    }
}