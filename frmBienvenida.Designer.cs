namespace Proyecto_s_p1
{
    partial class frmBienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBienvenido1 = new System.Windows.Forms.Label();
            this.lblBienvenido2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ARCOR S.A";
            // 
            // lblBienvenido1
            // 
            this.lblBienvenido1.AutoSize = true;
            this.lblBienvenido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBienvenido1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenido1.Location = new System.Drawing.Point(12, 62);
            this.lblBienvenido1.Name = "lblBienvenido1";
            this.lblBienvenido1.Size = new System.Drawing.Size(386, 26);
            this.lblBienvenido1.TabIndex = 7;
            this.lblBienvenido1.Text = "Bienvenido a la aplicación de ARCOR ";
            this.lblBienvenido1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBienvenido2
            // 
            this.lblBienvenido2.AutoSize = true;
            this.lblBienvenido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBienvenido2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenido2.Location = new System.Drawing.Point(74, 103);
            this.lblBienvenido2.Name = "lblBienvenido2";
            this.lblBienvenido2.Size = new System.Drawing.Size(337, 17);
            this.lblBienvenido2.TabIndex = 8;
            this.lblBienvenido2.Text = "Fábrica de alimentos, chocolates, galletas y helados";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(126, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(185, 191);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdCerrar.Location = new System.Drawing.Point(103, 394);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(208, 40);
            this.cmdCerrar.TabIndex = 10;
            this.cmdCerrar.Text = "&Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdcerrar_click);
            this.cmdCerrar.MouseLeave += new System.EventHandler(this.cmdCerrar_MouseLeave);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(467, 490);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblBienvenido2);
            this.Controls.Add(this.lblBienvenido1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBienvenido1;
        private System.Windows.Forms.Label lblBienvenido2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button cmdCerrar;
    }
}

