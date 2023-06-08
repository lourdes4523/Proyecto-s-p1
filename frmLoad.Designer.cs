namespace Proyecto_s_p1
{
    partial class frmLoad
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAA = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.pg = new System.Windows.Forms.Panel();
            this.pv = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.pg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ARCOR S.A";
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAA.Location = new System.Drawing.Point(226, 156);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(174, 33);
            this.lblAA.TabIndex = 8;
            this.lblAA.Text = "ARCOR S.A";
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCargando.Location = new System.Drawing.Point(113, 324);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(387, 42);
            this.lblCargando.TabIndex = 9;
            this.lblCargando.Text = "Bienvenido al Sistema";
            this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pg
            // 
            this.pg.Controls.Add(this.pv);
            this.pg.Location = new System.Drawing.Point(3, 369);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(579, 14);
            this.pg.TabIndex = 10;
            // 
            // pv
            // 
            this.pv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pv.Location = new System.Drawing.Point(0, 0);
            this.pv.Name = "pv";
            this.pv.Size = new System.Drawing.Size(57, 14);
            this.pv.TabIndex = 1;
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(571, 389);
            this.Controls.Add(this.pg);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.lblAA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoad";
            this.Load += new System.EventHandler(this.frmLoad_Load);
            this.pg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Panel pg;
        private System.Windows.Forms.Panel pv;
        private System.Windows.Forms.Timer timerLoad;
    }
}