using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_s_p1
{
    public partial class frmLoad : Form
    {
        frmLogin lg = new frmLogin();

        public frmLoad()
        {
            InitializeComponent();
        }


        private void timerLoad_Tick(object sender, EventArgs e)
        {
            pv.Width += 3;
            if (pv.Width > 599)
            {
                timerLoad.Stop();
                lg.Show();
                this.Hide();
            }
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            int LoadGordo = this.Width;
            int LoadAlto = this.Height;

            int lblGordo = lblCargando.Width;
            int lblAlto = lblCargando.Height;

            int lblX = (LoadGordo - lblGordo) / 2;
            int lblY = (LoadAlto - lblAlto) / 2;

            lblCargando.Location = new Point(lblX, lblY);
        }

    }

}