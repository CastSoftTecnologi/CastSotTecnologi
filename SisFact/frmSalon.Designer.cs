
namespace SisFact
{
    partial class frmSalon
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
            this.Panel_Mesas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPiso3 = new System.Windows.Forms.Button();
            this.BtnPiso2 = new System.Windows.Forms.Button();
            this.BtnPiso1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Mesas
            // 
            this.Panel_Mesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Mesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Mesas.Location = new System.Drawing.Point(12, 12);
            this.Panel_Mesas.Name = "Panel_Mesas";
            this.Panel_Mesas.Size = new System.Drawing.Size(714, 461);
            this.Panel_Mesas.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnPiso3);
            this.panel2.Controls.Add(this.BtnPiso2);
            this.panel2.Controls.Add(this.BtnPiso1);
            this.panel2.Location = new System.Drawing.Point(732, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 460);
            this.panel2.TabIndex = 3;
            // 
            // BtnPiso3
            // 
            this.BtnPiso3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPiso3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPiso3.ForeColor = System.Drawing.Color.Gray;
            this.BtnPiso3.Location = new System.Drawing.Point(3, 65);
            this.BtnPiso3.Name = "BtnPiso3";
            this.BtnPiso3.Size = new System.Drawing.Size(104, 25);
            this.BtnPiso3.TabIndex = 26;
            this.BtnPiso3.Text = "Piso 3";
            this.BtnPiso3.UseVisualStyleBackColor = true;
            this.BtnPiso3.Click += new System.EventHandler(this.BtnPiso3_Click);
            // 
            // BtnPiso2
            // 
            this.BtnPiso2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPiso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPiso2.ForeColor = System.Drawing.Color.Gray;
            this.BtnPiso2.Location = new System.Drawing.Point(3, 34);
            this.BtnPiso2.Name = "BtnPiso2";
            this.BtnPiso2.Size = new System.Drawing.Size(104, 25);
            this.BtnPiso2.TabIndex = 25;
            this.BtnPiso2.Text = "Piso 2";
            this.BtnPiso2.UseVisualStyleBackColor = true;
            this.BtnPiso2.Click += new System.EventHandler(this.BtnPiso2_Click);
            // 
            // BtnPiso1
            // 
            this.BtnPiso1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPiso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPiso1.ForeColor = System.Drawing.Color.Gray;
            this.BtnPiso1.Location = new System.Drawing.Point(3, 3);
            this.BtnPiso1.Name = "BtnPiso1";
            this.BtnPiso1.Size = new System.Drawing.Size(104, 25);
            this.BtnPiso1.TabIndex = 24;
            this.BtnPiso1.Text = "Piso 1";
            this.BtnPiso1.UseVisualStyleBackColor = true;
            this.BtnPiso1.Click += new System.EventHandler(this.BtnPiso1_Click);
            // 
            // frmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(855, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Mesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalon";
            this.Load += new System.EventHandler(this.frmSalon_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Mesas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPiso3;
        private System.Windows.Forms.Button BtnPiso2;
        private System.Windows.Forms.Button BtnPiso1;
    }
}