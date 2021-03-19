
namespace SisFact
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            this.LbHora = new System.Windows.Forms.Label();
            this.fnHora = new System.Windows.Forms.Timer(this.components);
            this.LbFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbHora
            // 
            this.LbHora.AutoSize = true;
            this.LbHora.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHora.ForeColor = System.Drawing.Color.White;
            this.LbHora.Location = new System.Drawing.Point(161, 145);
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(319, 124);
            this.LbHora.TabIndex = 0;
            this.LbHora.Text = "label1";
            // 
            // fnHora
            // 
            this.fnHora.Enabled = true;
            this.fnHora.Interval = 1000;
            this.fnHora.Tick += new System.EventHandler(this.fnHora_Tick);
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFecha.ForeColor = System.Drawing.Color.Gray;
            this.LbFecha.Location = new System.Drawing.Point(176, 256);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(90, 35);
            this.LbFecha.TabIndex = 1;
            this.LbFecha.Text = "label1";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.LbHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHora;
        private System.Windows.Forms.Timer fnHora;
        private System.Windows.Forms.Label LbFecha;
    }
}